--V-Persona
--Select
create procedure [dbo].[sp_select_V_Persona]
as
select [IdPersona]
      ,[Nombre]
      ,[Direccion]
      ,[Descripcion] from [ClubCampestre].[dbo].[V_Persona]
go

-- Filtrar
create procedure [dbo].[sp_search_V_Persona]
(
	@IdPersona varchar (20) ,@Nombre varchar (50) ,@Direccion varchar (150) ,@Descripcion varchar (15)
)
as
SELECT [IdPersona]
      ,[Nombre]
      ,[Direccion]
      ,[Descripcion]
  FROM [ClubCampestre].[dbo].[V_Persona]
  WHERE [IdPersona] LIKE '%' + ISNULL(@IdPersona, [IdPersona]) + '%'
AND [Nombre] LIKE '%' + ISNULL(@Nombre, [Nombre]) + '%'
AND [Direccion] LIKE '%' + ISNULL(@Direccion, [Direccion]) + '%'
AND [Descripcion] LIKE '%' + ISNULL(@Descripcion, [Descripcion]) + '%'
go

--V_Clientes


--V_Membresias

