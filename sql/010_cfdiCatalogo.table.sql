IF not EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.cfdiCatalogo') AND OBJECTPROPERTY(id,N'IsTable') = 1)
begin
	create table dbo.cfdiCatalogo
	(
	tipo		varchar(5) NOT NULL default 'NA',
	clave		varchar(10) NOT NULL default '',
	descripcion varchar(150) NOT NULL default '',
	CONSTRAINT pkCfdiCatalogo primary key nonclustered
	(tipo, clave) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) on [PRIMARY];
end
else
begin
	ALTER TABLE dbo.cfdiCatalogo DROP CONSTRAINT pkCfdiCatalogo;
	alter table dbo.cfdiCatalogo alter column clave varchar(10) not null;
	ALTER TABLE dbo.cfdiCatalogo ADD CONSTRAINT pkCfdiCatalogo PRIMARY KEY (tipo, clave);
end
go

------------------------------------------------------------------------------------

IF OBJECT_ID ('dbo.fCfdiCatalogoGetDescripcion') IS NOT NULL
   DROP FUNCTION dbo.fCfdiCatalogoGetDescripcion
GO

create function dbo.fCfdiCatalogoGetDescripcion(@tipo varchar(5), @clave varchar(10))
returns table 
as
--Prop�sito. Obtiene la descripci�n de los c�digos del cat�logo
--21/11/17 jcf Creaci�n cfdi 3.3
--
return(
	select descripcion
	from dbo.cfdiCatalogo ct
    where ct.tipo = @tipo
	and ct.clave = @clave
)

go

IF (@@Error = 0) PRINT 'Creaci�n exitosa de: fCfdiCatalogoGetDescripcion()'
ELSE PRINT 'Error en la creaci�n de: fCfdiCatalogoGetDescripcion()'
GO


--FRPG Forma de pago
------------------------------------------------------------------------------------
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = '01')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', '01', 'Efectivo');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = '02')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', '02', 'Cheque nominativo');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = '03')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', '03', 'Transferencia electr�nica de fondos');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = '04')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', '04', 'Tarjeta de Cr�dito');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = '05')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', '05', 'Monedero Electr�nico');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = '06')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', '06', 'Dinero electr�nico');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = '08')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', '08', 'Vales de despensa');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = '28')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', '28', 'Tarjeta de D�bito');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = '29')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', '29', 'Tarjeta de Servicio');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = '99')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', '99', 'Otros');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPG' and clave = 'NA')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPG', 'NA', 'NA');
----------------------------------------------------------------------------------------
--Forma de pago bancarizada
--En la descripci�n indicar los flags 1 � 0 para cada atributo
--Bancarizado|	N�mero de operaci�n|	RFC del Emisor de la cuenta ordenante|	Cuenta Ordenante|	RFC del Emisor Cuenta de Beneficiario|	Cuenta de Benenficiario| Tipo Cadena Pago|	Nombre del Banco emisor de la cuenta ordenante en caso de extranjero
--  1                2                       3                                      4                          5                                 6                        7                           8
--Se asume que los que no est�n en la lista, tienen todos los flags en cero
--El flag cero indica que no se incluye aunque est� configurado
--El flag uno indica que se incluye si est� configurado
--
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPGB' and clave = '02')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPGB', '02', '11111101');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPGB' and clave = '03')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPGB', '03', '11111101');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPGB' and clave = '04')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPGB', '04', '11111101');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPGB' and clave = '05')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPGB', '05', '11111101');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPGB' and clave = '06')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPGB', '06', '11110000');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPGB' and clave = '28')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPGB', '28', '11111101');

if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'FRPGB' and clave = '29')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('FRPGB', '29', '11111101');

-----------------------------------------------------------------------------------------
--M�todo de pago
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'MTDPG' and clave = 'PUE')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('MTDPG', 'PUE', 'Pago en una sola exhibici�n');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'MTDPG' and clave = 'PIP')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('MTDPG', 'PIP', 'Pago inicial y parcialidades');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'MTDPG' and clave = 'PPD')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('MTDPG', 'PPD', 'Pago en parcialidades o diferido');

-----------------------------------------------------------------------------------------
--R�gimen fiscal
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'RGFS' and clave = '601')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('RGFS', '601', 'General de Ley Personas Morales');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'RGFS' and clave = '623')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('RGFS', '623', 'Opcional para Grupos de Sociedades');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'RGFS' and clave = '629')
	insert into cfdiCatalogo(tipo, clave, descripcion)
	values('RGFS', '629', 'De los Reg�menes Fiscales Preferentes y de las Empresas Multinacionales');

-----------------------------------------------------------------------------------------
--Uso cfdi
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'G01') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'G01', 'Adquisici�n de mercancias');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'G02') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'G02', 'Devoluciones, descuentos o bonificaciones');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'G03') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'G03', 'Gastos en general');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'I01') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'I01', 'Construcciones');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'I02') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'I02', 'Mobilario y equipo de oficina por inversiones');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'I03') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'I03', 'Equipo de transporte');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'I04') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'I04', 'Equipo de computo y accesorios');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'I05') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'I05', 'Dados, troqueles, moldes, matrices y herramental');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'I06') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'I06', 'Comunicaciones telef�nicas');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'I07') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'I07', 'Comunicaciones satelitales');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'I08') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'I08', 'Otra maquinaria y equipo');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'D01') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'D01', 'Honorarios m�dicos, dentales y gastos hospitalarios.');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'D02') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'D02', 'Gastos m�dicos por incapacidad o discapacidad');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'D03') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'D03', 'Gastos funerales.');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'D04') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'D04', 'Donativos.');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'D05') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'D05', 'Intereses reales efectivamente pagados por cr�ditos hipotecarios (casa habitaci�n).');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'D06') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'D06', 'Aportaciones voluntarias al SAR.');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'D07') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'D07', 'Primas por seguros de gastos m�dicos.');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'D08') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'D08', 'Gastos de transportaci�n escolar obligatoria.');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'D09') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'D09', 'Dep�sitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'D10') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'D10', 'Pagos por servicios educativos (colegiaturas)');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'USCF' and clave = 'P01') insert into cfdiCatalogo(tipo, clave, descripcion) values('USCF', 'P01', 'Por definir');


-----------------------------------------------------------------------------------------
--unidad de medida
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'ACT') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'ACT', 'Actividad');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'H87') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'H87', 'Pieza');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'FOT') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'FOT', 'Pie');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'LTR') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'LTR', 'Litro');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'FTK') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'FTK', 'Pie cuadrado');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'MTR') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'MTR', 'Metro');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'INH') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'INH', 'Pulgada');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'HUR') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'HUR', 'Hora');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'A76') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'A76', 'Gal�n');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'E48') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'E48', 'Servicio');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'MON') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'MON', 'Mes ');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'XUN') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'XUN', 'Unidad');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'UDM' and clave = 'XKI') insert into cfdiCatalogo(tipo, clave, descripcion) values('UDM', 'XKI', '-');

-----------------------------------------------------------------------------------------
--TIPO RELACION
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'TPRL' and clave = '01') insert into cfdiCatalogo(tipo, clave, descripcion) values('TPRL', '01', 'Nota de cr�dito de los documentos relacionados');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'TPRL' and clave = '02') insert into cfdiCatalogo(tipo, clave, descripcion) values('TPRL', '02', 'Nota de d�bito de los documentos relacionados');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'TPRL' and clave = '03') insert into cfdiCatalogo(tipo, clave, descripcion) values('TPRL', '03', 'Devoluci�n de mercanc�a sobre facturas o traslados previos');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'TPRL' and clave = '04') insert into cfdiCatalogo(tipo, clave, descripcion) values('TPRL', '04', 'Sustituci�n de los CFDI previos');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'TPRL' and clave = '05') insert into cfdiCatalogo(tipo, clave, descripcion) values('TPRL', '05', 'Traslados de mercancias facturados previamente');
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'TPRL' and clave = '06') insert into cfdiCatalogo(tipo, clave, descripcion) values('TPRL', '06', 'Factura generada por los traslados previos');

GO

-----------------------------------------------------------------------------------------
--PRODUCTO ESPECIAL
if not exists(select 1 from dbo.cfdiCatalogo where tipo = 'PROD' and clave = '84111506') insert into cfdiCatalogo(tipo, clave, descripcion) values('PROD', '84111506', 'Servicios de facturaci�n');
go
-----------------------------------------------------------------------------------------
--select * from cfdiCatalogo
