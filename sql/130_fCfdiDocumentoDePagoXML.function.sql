IF OBJECT_ID ('dbo.fCfdiDocumentoDePagoXML') IS NOT NULL
   DROP FUNCTION dbo.[fCfdiDocumentoDePagoXML]
GO

create function [dbo].[fCfdiDocumentoDePagoXML] (@RMDTYPAL smallint, @DOCNUMBR varchar(21))
returns xml 
as
--Propósito. DEVOLVER UN XML PARA UN COBRO TOTALMENTE APLICADO Y CONTABILIZADO, DE OTRO MODO DEVOLVER NULL
--Requisitos. EL COBRO DEBE ESTAR TOTALMENTE APLICADO Y CONTABILIZADO
--24/10/17 LT Creación cfdi
--10/11/17 jcf Correcciones varias
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
		rtrim(tv.DOCNUMBR)									'@Folio',
		convert(datetime, GETDATE(), 126)					'@Fecha',
		''													'@Sello', 
		''													'@NoCertificado', 
		''													'@Certificado', 
		0.00												'@SubTotal',
		'XXX'												'@Moneda',
		0.00												'@total',
		'P'													'@tipoDeComprobante',
		rtrim(ci.zipcode)									'@LugarExpedicion',	
		case when r.NOTEINDX is not null then '04' else null end	'cfdi:CfdiRelacionados/@TipoRelacion',
		case when r.NOTEINDX is not null then r.uuid else null end	'cfdi:CfdiRelacionados/CfdiRelacionado/@UUID',
		rtrim(ci.taxregtn)									'cfdi:Emisor/@Rfc',
		rtrim(pa.inet8)										'cfdi:Emisor/@RegimenFiscal',
		rtrim(tv.txrgnnum)									'cfdi:Receptor/@Rfc',
		'P01'												'cfdi:Receptor/@UsoCFDI',
		case when tv.TXRGNNUM='XEXX010101000' then rtrim(tv.CCode) else null end
															'cfdi:Receptor/@ResidenciaFiscal',
		case when tv.TXRGNNUM='XEXX010101000' then rtrim(tv.taxexmt1) else null end
															'cfdi:Receptor/@NumRegIdTrib',
		'84111506'											'cfdi:Conceptos/cfdi:Concepto/@ClaveProdServ',
		'ACT'												'cfdi:Conceptos/cfdi:Concepto/@ClaveUnidad',
		1													'cfdi:Conceptos/cfdi:Concepto/@Cantidad',
		'Pago'												'cfdi:Conceptos/cfdi:Concepto/@Descripcion',
		0.00												'cfdi:Conceptos/cfdi:Concepto/@ValorUnitario',
		0.00												'cfdi:Conceptos/cfdi:Concepto/@Importe',

		dbo.fCfdiDocumentoDePagoXMLPagos(tv.rmdtypal,tv.docnumbr) 'cfdi:Complemento'
															
		from dbo.vwRmTransaccionesTodas tv
		left join dynamics.dbo.MC40200 c on c.CURNCYID = tv.CURNCYID
		left join dynamics.dbo.sy01500 ci on ci.interid = db_name()
		left join dbo.vwCfdiRelacionado r on r.NOTEINDX = tv.NOTEINDX
		outer apply dbo.fcfdiparametros('VERSION','NA','NA','NA','NA','NA','PREDETERMINADO') pa
	where tv.docnumbr =	@DOCNUMBR		
	and tv.RMDTYPAL = @RMDTYPAL
	and tv.CURTRXAM = 0
	FOR XML path('cfdi:Comprobante'), type
	)
	return @cfd;
end
go
---------------------------------------------------------------------

IF (@@Error = 0) PRINT 'Creación exitosa de: [fCfdiDocumentoDePagoXML]()'
ELSE PRINT 'Error en la creación de: [fCfdiDocumentoDePagoXML]()'
GO
