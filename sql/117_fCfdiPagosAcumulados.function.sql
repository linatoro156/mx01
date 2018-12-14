IF OBJECT_ID ('dbo.fCfdiPagosAcumulados') IS NOT NULL
   DROP FUNCTION dbo.fCfdiPagosAcumulados
GO

CREATE function dbo.fCfdiPagosAcumulados(@PAGOTIPO smallint, @PAGONUM varchar(21), @PAGOFECHA DATETIME, @FACTURATIPO smallint, @FACTURANUM varchar(21), @TRXDSCRN char(31))
returns table
--Prop�sito. Obtiene la suma de pagos aplicados a una factura y el n�mero de cuota
--27/10/17 jcf Creaci�n
--
as
return(
		SELECT COUNT(*) numCuota, 
			SUM(X.ORAPTOAM) sumaORAPTOAM,			--monto aplicado de la factura en moneda de la factura
			SUM(X.APPTOAMT) sumaAPPTOAMT,			--monto aplicado de la factura en moneda funcional
			SUM(X.apfrmaplyamt) sumaApfrmaplyamt,	--monto aplicado del pago en moneda funcional
			sum(X.APFRMWROFAMT) sumaAPFRMWROFAMT,	--monto cancelado del pago en moneda funcional
			sum(X.actualapplytoamount) sumaActualapplytoamount	--monto aplicado del pago en moneda del pago
		FROM dbo.vwCfdiRmTrxAplicadas X
			--inner join vwRmTransaccionesTodas rm
			--on X.APFRDCNM = rm.docnumbr
			--and X.APFRDCTY = rm.RMDTYPAL
			--AND rm.VOIDSTTS = 0 
		WHERE X.APTODCNM = @FACTURANUM
		and X.APTODCTY = @FACTURATIPO
		AND X.idPago <= convert(varchar(12), @PAGOFECHA, 112) + rtrim(@PAGONUM)
		AND X.APFRDCTY = @PAGOTIPO
)
go

IF (@@Error = 0) PRINT 'Creaci�n exitosa de: fCfdiPagosAcumulados'
ELSE PRINT 'Error en la creaci�n de: fCfdiPagosAcumulados'
GO

--------------------------------------------------------------------------------------------------------------------------------------------------------
IF OBJECT_ID ('dbo.fCfdiRmAjusteAcumuladoDeRevaluacion') IS NOT NULL
   DROP FUNCTION dbo.fCfdiRmAjusteAcumuladoDeRevaluacion
GO

CREATE function dbo.fCfdiRmAjusteAcumuladoDeRevaluacion(@docnumbr char(21), @doctype smallint, @curncyid char(15), @rvludate datetime)
returns table
--Prop�sito. Obtiene el �ltimo ajuste acumulado de revaluaci�n
--Requisito. gainloss = g/p no producida
--24/11/17 jcf Creaci�n
--
as
return(
	select top(1) Total_Gain_or_Loss_on_Cu, xchgrate
	from mc020104		--mc_rm_revaluation
	where docnumbr = @docnumbr
	and doctype = @doctype
	and GAINLOSS = 0	--g/p no producida
	and curncyid = @curncyid
	and datediff(day, '1/31/14', @rvludate) <= 0
	order by rvludate desc, dex_row_id desc
)
go

IF (@@Error = 0) PRINT 'Creaci�n exitosa de: fCfdiRmAjusteAcumuladoDeRevaluacion'
ELSE PRINT 'Error en la creaci�n de: fCfdiRmAjusteAcumuladoDeRevaluacion'
GO

