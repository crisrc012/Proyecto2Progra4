USE [ClubCampestre]
GO
create procedure [dbo].[sp_search_cargar_membresia]
(
	@IdPersona varchar (20)
)
as
select c.IdPersona as IdPersona, c.Nombre as Nombre, d.Descripcion as TipoCliente , e.Descripcion as Membresia, e.costo from TB_Membresias as a
inner join TB_Clientes as b on a.IdCliente = b.IdCliente
inner join TB_Persona as c on b.IdPersona = c.IdPersona
inner join TB_TipoCliente as d on b.IdTipoCliente = d.IdTipoCliente
inner join TB_TipoMembresia as e on a.IdTipoMembresia = e.IdTipoMembresia
where c.IdPersona = @IdPersona
GO
-- Filtrar
create procedure [dbo].[sp_search_Beneficiarios_Personas]
(
	@IdPersona varchar (20) 
)
as
declare @count int
select @count = count(IdPersona) from TB_Beneficiarios
where IdPersona = @IdPersona
if (@count != 0) 
begin
select a.IdPersona as IdPersona, b.Nombre as Nombre, 'Beneficiario' as Tipo, (d.costo/16) as costo from TB_Beneficiarios as a
inner join TB_Persona as b on a.IdPersona = b.IdPersona
inner join TB_Membresias as c on a.IdCliente = c.IdCliente
inner join TB_TipoMembresia as d on c.IdTipoMembresia = d.IdTipoMembresia
 where a.IdPersona = @IdPersona
 end
else
begin
select  a.IdPersona as IdPersona, a.Nombre as Nombre, 'Beneficiario' as Tipo, 5000 as costo from TB_Persona as a
 where a.IdPersona = @IdPersona
 end
go

create procedure [dbo].[sp_insert_Ingreso_factura]
(
	@IdPersona varchar (20), @Costo float
)
as
insert into TB_Ingresos select a.IdCliente, a.IdMembresia, getdate() from TB_Membresias as a
inner join TB_Clientes as b on a.IdCliente = b.IdCliente
inner join  TB_Persona as c on  b.IdPersona = c.IdPersona
where c.IdPersona = @IdPersona
insert into Tb_Facturacion select IdCliente, 'Factura', getdate(), @Costo from TB_Clientes 
where IdPersona = @IdPersona
go


create procedure [dbo].[sp_insert_detalle_factura]
(
	@IdPersona varchar (20), @Costo float, @IdTipoServicio tinyint, @Total float
)
as

insert into Tb_FacturaDetalle select max(idfactura), '', @Costo,isnull(@IdTipoServicio,1) , b.IdTipoMembresia, 1, @Total  from Tb_Facturacion as a
inner join TB_Membresias as b on a.IdCliente = b.IdCliente
inner join TB_Clientes as c on b.IdCliente = c.IdCliente
where c.IdPersona = @IdPersona
group by b.IdTipoMembresia
GO

