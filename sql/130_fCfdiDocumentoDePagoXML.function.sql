USE [MEX10]
GO


ALTER function [dbo].[fCfdiDocumentoDePagoXML] (@RMDTYPAL smallint, @DOCNUMBR varchar(21))
returns xml 
as
--Propósito. DEVOLVER UN XML PARA UN COBRO TOTALMENTE APLICADO Y CONTABILIZADO, DE OTRO MODO DEVOLVER NULL
--Requisitos. EL COBRO DEBE ESTAR TOTALMENTE APLICADO Y CONTABILIZADO
--24/10/2017 LT Creación cfdi
--
begin
	declare @cfd xml;
	WITH XMLNAMESPACES
	(
				'http://www.w3.org/2001/XMLSchema-instance' as "xsi",
				'http://www.sat.gob.mx/cfd/3' as "cfdi",
				'http://www.sat.gob.mx/Pagos' as "pago10"
	)
	select @cfd = 
	(select 
		'http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd http://www.sat.gob.mx/Pagos http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos10.xsd'	
															'@xsi:schemaLocation',
		rtrim(pa.param1)									'@Version',
		'CBR'												'@Serie',
		rtrim(tv.DOCNUMBR)									'@folio',
		convert(datetime, GETDATE(), 126)					'@fecha',
		''													'@sello', 
		''													'@noCertificado', 
		''													'@certificado', 
		0.00												'@subTotal',
		'XXX'												'@Moneda',
		0.00												'@total',
		'P'													'@tipoDeComprobante',
		rtrim(ci.zipcode)									'@LugarExpedicion',	
		rtrim(ci.taxregtn)									'cfdi:emisor/@rfc',
		rtrim(pa.inet8)										'cfdi:emisor/@RegimenFiscal',
		rtrim(tv.txrgnnum)									'cfdi:Receptor/@rfc',
		'PO1'												'cfdi:Receptor/@UsoCFDO',
		case when tv.TXRGNNUM='XEXX010101000' then pac.param1 else null end
															'cfdi:Receptor/@ResidenciaFiscal',
		case when tv.TXRGNNUM='XEXX010101000' then pac.param2 else null end
															'cfdi:Receptor/@NumRegIdTrib',
		'84111506'											'cfdi:Conceptos/cfdi:Concepto/@ClaveProdServ',
		'ACT'												'cfdi:Conceptos/cfdi:Concepto/@ClaveUnidad',
		1													'cfdi:Conceptos/cfdi:Concepto/@Cantidad',
		'Pago'												'cfdi:Conceptos/cfdi:Concepto/@Descripcion',
		0.00												'cfdi:Conceptos/cfdi:Concepto/@ValorUnitario',
		0.00												'cfdi:Conceptos/cfdi:Concepto/@Importe',

		dbo.fCfdiDocumentoDePagoXMLPagos(tv.rmdtypal,tv.docnumbr) 'cfdi:Complemento'
															
		from vwRmTransaccionesTodas tv
		left join dynamics.dbo.MC40200 c on c.CURNCYID = tv.CURNCYID
		left join dynamics.dbo.sy01500 ci on ci.interid = db_name()
		outer apply dbo.fcfdiparametros('VERSION','NA','NA','NA','NA','NA','PREDETERMINADO') pa
		outer apply dbo.fCfdiParametrosCliente(tv.CUSTNMBR,'ResidenciaFiscal','NumRegIdTrib','NA','NA','NA','NA','PREDETERMINADO') pac
	where tv.docnumbr =	@DOCNUMBR		
	and tv.RMDTYPAL = @RMDTYPAL
	and tv.CURTRXAM = 0
	FOR XML path('cfdi:Comprobante'), type
	)
	return @cfd;
end

go

---------------------------------------------------------------------
--select [dbo].[fCfdiDocumentoDePagoXML] (9, 'PYMNT00000029')
