IF OBJECT_ID ('dbo.fCfdiDocumentoDePagoXMLPagos') IS NOT NULL
   DROP FUNCTION dbo.fCfdiDocumentoDePagoXMLPagos
GO


create function [dbo].fCfdiDocumentoDePagoXMLPagos (@RMDTYPAL smallint, @DOCNUMBR varchar(21))
returns xml 
as
--Prop�sito. Obtiene nodo Pagos
--Requisitos. -
--24/10/2017 LT Creaci�n cfdi
--
begin
	declare @cnp xml;
	WITH XMLNAMESPACES
	(
				'http://www.sat.gob.mx/Pagos' as "pago10"
	)
	select @cnp = 
		(SELECT  '1.0'											'@Version',
			[dbo].fCfdiDocumentoDePagoXMLPago (@RMDTYPAL, @DOCNUMBR)
		FOR XML PATH('pago10:Pagos'), Type
		)
	return @cnp;
end

go


IF (@@Error = 0) PRINT 'Creaci�n exitosa de: [fCfdiDocumentoDePagoXMLPagos]()'
ELSE PRINT 'Error en la creaci�n de: [fCfdiDocumentoDePagoXMLPagos]()'
GO
