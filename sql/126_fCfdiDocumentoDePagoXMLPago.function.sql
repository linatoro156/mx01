IF OBJECT_ID ('dbo.fCfdiDocumentoDePagoXMLPago') IS NOT NULL
   DROP FUNCTION dbo.fCfdiDocumentoDePagoXMLPago
GO


create function [dbo].fCfdiDocumentoDePagoXMLPago (@RMDTYPAL smallint, @DOCNUMBR varchar(21))
returns xml 
as
--Prop�sito. DEVOLVER UN XML PARA UN COBRO TOTALMENTE APLICADO Y CONTABILIZADO, DE OTRO MODO DEVOLVER NULL
--Requisitos. EL COBRO DEBE ESTAR TOTALMENTE APLICADO Y CONTABILIZADO
--24/10/17 lt Creaci�n cfdi
--10/11/17 jcf Correcciones varias
--
begin
	declare @cnp xml;
	WITH XMLNAMESPACES
	(
				'http://www.sat.gob.mx/Pagos' as "pago10"
	)
	select @cnp = 
		(SELECT  
			convert(datetime, hdr.docdate, 126)					'@FechaPago',

			CASE WHEN pa.PARAM2='SI' then Rtrim(mcp.grupid) 
				else 
 					case hdr.CSHRCTYP 
 						when 0 then '02' 
 						when 1 then left(Rtrim(ch.CMUSRDF1), 2)
 						when 2 then left(hdr.FRTSCHID,2)
						else null 
					end 
			end												    '@FormaDePagoP',
 			LTRIM(RTRIM(C.ISOCURRC))							'@MonedaP',
			case when c.ISOCURRC<>'MXN' THEN cast(hdr.XCHGRATE as numeric(19,6)) else null END
																'@TipoCambioP',

			cast(hdr.ORTRXAMT as numeric(19,2))					'@Monto',
			[dbo].[fCfdiDocumentoDePagoXML_Nodo_Relacionado] (hdr.RMDTYPAL, hdr.DOCNUMBR)
		FROM vwRmTransaccionesTodas  AS hdr
 			left join dynamics.dbo.MC40200 c on c.CURNCYID = HDR.CURNCYID
 			left join CM00100 ch on ch.CHEKBKID=hdr.CBKIDCHK
			outer apply dbo.fCfdiMcpFormaPago(hdr.DOCNUMBR) mcp
 			outer apply dbo.fcfdiparametros('NA','MCP','NA','NA','NA','NA','PREDETERMINADO') pa
		where hdr.docnumbr = @DOCNUMBR	
			and hdr.RMDTYPAL = @RMDTYPAL
			FOR XML PATH('pago10:Pago'), Type	--, root('pago10:Pagos')
		)
	return @cnp;
end

go

IF (@@Error = 0) PRINT 'Creaci�n exitosa de: [fCfdiDocumentoDePagoXMLPago]()'
ELSE PRINT 'Error en la creaci�n de: [fCfdiDocumentoDePagoXMLPago]()'
GO
