USE [ClubCampestre]
GO




create procedure [dbo].[sp_search_cargar_membresia]


(
	@IdPersona varchar, @Nombre varchar, @TipoCliente varchar, @Membrresia varchar, @costo float 
)


as

select c.IdPersona as IdPersona, c.Nombre as Nombre, d.Descripcion as TipoCliente , e.Descripcion as Membresia, e.costo from TB_Membresias as a
inner join TB_Clientes as b on a.IdCliente = b.IdCliente
inner join TB_Persona as c on b.IdPersona = c.IdPersona
inner join TB_TipoCliente as d on b.IdTipoCliente = d.IdTipoCliente
inner join TB_TipoMembresia as e on a.IdTipoMembresia = e.IdTipoMembresia
where c.IdPersona = @IdPersona
GO


