--------------------------------------------------------------------------------------------------------

IF OBJECT_ID ('dbo.fCfdiMetodoYFormaPago') IS NOT NULL
   DROP FUNCTION dbo.fCfdiMetodoYFormaPago
GO

create function dbo.fCfdiMetodoYFormaPago(@soptype smallint, @orpmtrvd numeric(19,5), @total numeric(19,5), @metodoPagoUsr varchar(5), @FormaPagoRel varchar(2), @FormaPagoSimu varchar(2), @FormaPagoUsr varchar(2))
returns table
as
--Prop�sito. Devuelve el m�todo de pago PUE, PPD; y la forma de pago. 
--		El usuario puede ingresar el m�todo de pago PUE y la forma de pago al momento de ingresar la factura.
--		Independiente de lo que ingrese el usuario, si el pago es simult�neo el m�todo es PUE
--Requisitos. -
--16/11/18 jcf Creaci�n cfdi
--
return
( 
	select	case when @soptype = 3 then
				case when @orpmtrvd = @total then	--pago simult�neo
					 'PUE'
				Else 
					case when isnull(@metodoPagoUsr, '') != '' then
						@metodoPagoUsr 
					else 'PPD'
					end
				END
			else 
				case when @FormaPagoRel = '99' then
					'PPD'
				Else 'PUE'
				END
			end	metodoPago,
			
			case when @soptype = 3 then
				case when @orpmtrvd = @total then	--pago simult�neo
					@FormaPagoSimu
				else 
					case when isnull(@metodoPagoUsr, '') = 'PUE' and isnull(@FormaPagoUsr, '') != '' then
						@FormaPagoUsr 
					else '99'
					end
				end
			else @FormaPagoRel
			end formaPago
)
go

IF (@@Error = 0) PRINT 'Creaci�n exitosa de la funci�n: fCfdiMetodoYFormaPago()'
ELSE PRINT 'Error en la creaci�n de la funci�n: fCfdiMetodoYFormaPago()'
GO
--------------------------------------------------------------------------------------------------------

