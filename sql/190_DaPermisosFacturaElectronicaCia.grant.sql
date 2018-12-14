--M�xico 
--Factura Electr�nica
--Prop�sito. Rol que da accesos a objetos de factura electr�nica
--Requisitos. Ejecutar en la compa��a.
--24/05/11 JCF Creaci�n
--
-----------------------------------------------------------------------------------
--use arg10

IF DATABASE_PRINCIPAL_ID('rol_cfdigital') IS NULL
	create role rol_cfdigital;

--Objetos que usa factura electr�nica
grant select, insert, update, delete on cfdLogFacturaXML to rol_cfdigital, dyngrp;
grant execute on proc_cfdLogFacturaXMLLoadByPrimaryKey to rol_cfdigital, dyngrp;
grant execute on proc_cfdLogFacturaXMLLoadAll to rol_cfdigital, dyngrp;
grant execute on proc_cfdLogFacturaXMLUpdate to rol_cfdigital, dyngrp;
grant execute on proc_cfdLogFacturaXMLInsert to rol_cfdigital, dyngrp;
grant execute on proc_cfdLogFacturaXMLDelete to rol_cfdigital, dyngrp;

grant select on dbo.vwCfdiPagosSimultaneos to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdiTransaccionesDeVenta to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdiDocumentosAImprimir to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdIdDocumentos  to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdClienteDireccionesCorreo to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdCartasReclamacionDeuda to rol_cfdigital, dyngrp;

grant select on dbo.vwRmCfdiFacturasConFolioFiscal to rol_cfdigital, dyngrp;
grant select on dbo.fCfdiParametros to rol_cfdigital;

grant select on dbo.vwCfdiTrxCobros to rol_cfdigital;

grant select on dbo.vwCfdiTrasladosUserInterface to rol_cfdigital;
grant select on dbo.vwCfdiTrasladosDatosParaImprimir to rol_cfdigital;
