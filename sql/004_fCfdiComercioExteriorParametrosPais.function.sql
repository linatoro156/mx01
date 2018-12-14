
IF OBJECT_ID ('dbo.fCfdiComercioExteriorParametrosPais') IS NOT NULL
   DROP FUNCTION dbo.fCfdiComercioExteriorParametrosPais
GO

create function dbo.fCfdiComercioExteriorParametrosPais(@CCode char(7), @tag1 varchar(17), @tag2 varchar(17))
returns table
as
--Prop�sito. Devuelve los par�metros de un pa�s
--Requisitos. Los @tagx deben configurarse en la ventana de notas del pa�s
--10/01/18 jcf Creaci�n
--
return
(
	select 
			case when charindex(@tag1+'=', nota.txtfield) > 0 and charindex(char(13), nota.txtfield, charindex(@tag1+'=', nota.txtfield)) > 0 then
				substring(nota.txtfield, charindex(@tag1+'=', nota.txtfield) +len(@tag1)+1, charindex(char(13), nota.txtfield, charindex(@tag1+'=', nota.txtfield)) - charindex(@tag1+'=', nota.txtfield) - len(@tag1)-1) 
			else 'no existe tag: '+@tag1 
			end param1,
			case when charindex(@tag2+'=', nota.txtfield) > 0 and charindex(char(13), nota.txtfield, charindex(@tag2+'=', nota.txtfield)) > 0 then
				substring(nota.txtfield, charindex(@tag2+'=', nota.txtfield) +len(@tag2)+1, charindex(char(13), nota.txtfield, charindex(@tag2+'=', nota.txtfield)) - charindex(@tag2+'=', nota.txtfield) - len(@tag2)-1) 
			else 'no existe tag: '+@tag2 
			end param2
	from VAT10001 pais
	inner join SY03900 nota
		on nota.NOTEINDX = pais.NOTEINDX
	where pais.CCode = @CCode
)
go


IF (@@Error = 0) PRINT 'Creaci�n exitosa de la funci�n: fCfdiComercioExteriorParametrosPais()'
ELSE PRINT 'Error en la creaci�n de la funci�n: fCfdiComercioExteriorParametrosPais()'
GO

-----------------------------------------------------------------------------

--select * from SY03900
--WHERE NOTEINDX = 2158


--sp_statistics VAT10001
--sp_columns VAT10001
