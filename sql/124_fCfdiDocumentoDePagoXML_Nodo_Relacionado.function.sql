IF OBJECT_ID ('dbo.fCfdiDocumentoDePagoXML_Nodo_Relacionado') IS NOT NULL
   DROP FUNCTION dbo.[fCfdiDocumentoDePagoXML_Nodo_Relacionado]
GO

create function [dbo].[fCfdiDocumentoDePagoXML_Nodo_Relacionado] (@RMDTYPAL smallint, @DOCNUMBR varchar(21))
returns xml 
as
--Propósito. Devuelve el nodo DoctoRelacionado
--Requisitos. -
--24/10/2017 lt Creación cfdi
--
begin
	declare @cnp xml;
	WITH XMLNAMESPACES
	(
				'http://www.sat.gob.mx/Pagos' as "pago10"
	)
	select @cnp = 
	(
        SELECT     
        IdDocumento											'@IdDocumento',
		MonedaDR											'@MonedaDR',
		cast(TipoCambioDR as numeric(19,6))					'@TipoCambioDR',
		'PPD'												'@MetodoDePagoDR',
		NumParcialidad										'@NumParcialidad',
		cast(ImpSaldoAnt as numeric(19,6))					'@ImpSaldoAnt',
		cast(ImpPagado as numeric(19,6))					'@ImpPagado',
		cast(ImpSaldoInsoluto as numeric(19,6))				'@ImpSaldoInsoluto'
		from dbo.vwCfdiRMFacturas line
        WHERE  line.DOCNUMBR = @DOCNUMBR
		and line.RMDTYPAL = @RMDTYPAL
        FOR XML PATH ('pago10:DoctoRelacionado'), type

	)
	return @cnp;
end
go



IF (@@Error = 0) PRINT 'Creación exitosa de: [fCfdiDocumentoDePagoXML_Nodo_Relacionado]()'
ELSE PRINT 'Error en la creación de: [fCfdiDocumentoDePagoXML_Nodo_Relacionado]()'
GO
--select [dbo].[fCfdiDocumentoDePagoXML_Nodo_Relacionado] (9, 'PYMNT00000029')