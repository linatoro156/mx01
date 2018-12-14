IF not EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.nfmcp20100') AND OBJECTPROPERTY(id,N'IsTable') = 1)
begin
	create table dbo.nfmcp20100
	(
	[MCPTYPID] [char](21) NOT NULL,
	[NUMBERIE] [char](21) NOT NULL,
	[LNSEQNBR] [numeric](19, 5) NOT NULL,
	[MEDIOID] [char](21) NOT NULL,
	[BANKID] [char](15) NOT NULL,
	[DOCNUMBR] [char](21) NOT NULL,
	[LOCATNNM] [char](31) NOT NULL,
	[TITACCT] [char](65) NOT NULL,
	[EMIDATE] [datetime] NOT NULL,
	[DUEDATE] [datetime] NOT NULL,
	[LINEAMNT] [numeric](19, 5) NOT NULL,
	[AMOUNTO] [numeric](19, 5) NOT NULL,
	[CURNCYID] [char](15) NOT NULL,
	[STSDESCR] [char](31) NOT NULL,
	[CURRNIDX] [smallint] NOT NULL,
	[BANACTID] [char](21) NOT NULL,
	[TII_MCP_Clearing] [smallint] NOT NULL,
	[TII_MCP_Checkbook_Integ] [tinyint] NOT NULL,
	[TII_MCP_Integrated_Date] [datetime] NOT NULL,
	[TII_CHEKBKID] [char](15) NOT NULL,
	[TXRGNNUM] [char](25) NOT NULL,
	[DEX_ROW_ID] [int] IDENTITY(1,1) NOT NULL
	) on [PRIMARY];
end

-----------------------------------------------------------------------------------------------------------------------------
IF not EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.nfmcp30100') AND OBJECTPROPERTY(id,N'IsTable') = 1)
begin
	create table dbo.nfmcp30100
	(
	[NUMBERIE] [char](21) NOT NULL,
	[MEDIOID] [char](21) NOT NULL,
	[LINEAMNT] [numeric](19, 5) NOT NULL,
	[TII_CHEKBKID] [char](15) NOT NULL,
	[DEX_ROW_ID] [int] IDENTITY(1,1) NOT NULL
	) on [PRIMARY];
end

-----------------------------------------------------------------------------------------------------------------------------
IF not EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'dbo.nfmcp00700') AND OBJECTPROPERTY(id,N'IsTable') = 1)
begin
	create table dbo.nfmcp00700
	(
	[GRUPID] [char](21) NOT NULL,
	[MEDIOID] [char](21) NOT NULL,
	[CHEKBKID] [char](15) NOT NULL
	) on [PRIMARY];
end

-----------------------------------------------------------------------------------------------------------------------------
IF OBJECT_ID ('dbo.fCfdiMcpFormaPago') IS NOT NULL
   DROP FUNCTION dbo.fCfdiMcpFormaPago
GO

create function dbo.fCfdiMcpFormaPago(@DOCNUMBR varchar(21))
returns table
--Prop�sito. Obtiene la forma de pago de MCP
--10/11/17 jcf Creaci�n
--14/02/18 jcf Agrega nfmcp30100
--
as
return(
	select top (1) mcpd.grupid, mcpfp.tii_chekbkid
	from
		( select tii_chekbkid, medioid, numberie, lineamnt  
		from nfmcp20100  
		union all
		select tii_chekbkid, medioid, numberie, lineamnt  
		from nfmcp30100  
		) mcpfp
 	left join nfmcp00700 mcpd 
		on mcpd.medioid=mcpfp.medioid
	where mcpfp.numberie = @DOCNUMBR
	order by mcpfp.lineamnt desc
)

go
IF (@@Error = 0) PRINT 'Creaci�n exitosa de: fCfdiMcpFormaPago()'
ELSE PRINT 'Error en la creaci�n de: fCfdiMcpFormaPago()'
GO
--------------------------------------------------------------------------------------------------------

