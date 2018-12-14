IF (OBJECT_ID ('dbo.vwRmCfdiFacturasConFolioFiscal', 'V') IS NULL)
   exec('create view dbo.vwRmCfdiFacturasConFolioFiscal as SELECT 1 as t');
go

alter view dbo.vwRmCfdiFacturasConFolioFiscal as
--Prop�sito. Facturas con folio fiscal
--14/10/15 jcf Creaci�n
--
select 
	rm.rmdtypal, rm.tipoDoc, rm.soptype, rm.docdate, rm.docnumbr, rm.voidstts, case when rm.voidstts = 1 then 'SI' else 'NO' end anulado, 
	rm.custnmbr, rm.custname, rm.txrgnnum, rm.totalImpuesto, rm.totalDoc, rm.duedate, 
	rm.curncyid, rm.curtrxam, rm.ortrxamt, rm.slsamnt, rm.cashamnt, rm.orctrxam, rm.ororgtrx, rm.xchgrate,
	cfdi.folioFiscal uuid, cfdi.docid, cfdi.mensajeEA
from vwRmTransaccionesTodas rm
left join vwCfdiDocumentosAImprimir cfdi
	on cfdi.soptype = rm.soptype
	and cfdi.sopnumbe = rm.docnumbr
where rmdtypal in (1, 8)	--facturas, devoluciones
--and year(docdate) = 2015
--and rm.custnmbr = '000000206'

go

IF (@@Error = 0) PRINT 'Creaci�n exitosa de la vista: vwRmCfdiFacturasConFolioFiscal'
ELSE PRINT 'Error en la creaci�n de la vista: vwRmCfdiFacturasConFolioFiscal'
GO

--grant select on vwRmCfdiFacturasConFolioFiscal to dyngrp;

--select * from vwRmCfdiFacturasConFolioFiscal


