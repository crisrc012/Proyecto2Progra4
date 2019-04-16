--V-Persona
--Select
create procedure [dbo].[sp_select_V_Persona]
as
SELECT [IdPersona] AS Identificacion
      ,[Nombre]
      ,[Direccion]
      ,[Descripcion] AS Rol
      ,[Telefono]
      ,[Correo]
  FROM [ClubCampestre].[dbo].[V_Persona]
go

-- Filtrar
create procedure [dbo].[sp_search_V_Persona]
(
	@IdPersona varchar (20) ,@Nombre varchar (50) ,@Direccion varchar (150) ,@Rol varchar (15)
)
as
SELECT [IdPersona] AS Identificacion
      ,[Nombre]
      ,[Direccion]
      ,[Descripcion] AS Rol
      ,[Telefono]
      ,[Correo]
  FROM [ClubCampestre].[dbo].[V_Persona]
  WHERE [IdPersona] LIKE '%' + ISNULL(@IdPersona, [IdPersona]) + '%'
AND [Nombre] LIKE '%' + ISNULL(@Nombre, [Nombre]) + '%'
AND [Direccion] LIKE '%' + ISNULL(@Direccion, [Direccion]) + '%'
AND [Descripcion] LIKE '%' + ISNULL(@Rol, [Descripcion]) + '%'
go

--V_Clientes


--V_Membresias
--SELECT
create procedure [dbo].[sp_select_V_Membresia]
as
SELECT [IdMembresia]
      ,[Identificacion]
      ,[Nombre]
      ,[Membresia]
      ,[Costo]
      ,[FechaInicio]
      ,[FechaVencimiento]
	  ,[Estado]
  FROM [ClubCampestre].[dbo].[V_Membresias]
go

-- V_Servicio
create procedure [dbo].[sp_select_V_Servicio]
as
SELECT [IdServicio]
      ,[Identificacion]
      ,[Nombre]
      ,[Tipo de Servicio]
      ,[Costo]
      ,[FechaRegistro]
      ,[Estado]
  FROM [ClubCampestre].[dbo].[V_Servicio]
  go
