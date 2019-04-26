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
if @IdPersona = ''
begin
	set @IdPersona = null
end
if @Nombre = ''
begin
	set @Nombre = null
end
if @Direccion = ''
begin
	set @Direccion = null
end
if @Rol = ''
begin
	set @Rol = null
end
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
--Select
CREATE PROCEDURE [dbo].[sp_select_V_Clientes]
AS
SELECT [IdCliente]
      ,[Tipo de Cliente]
      ,[IdPersona]
      ,[Nombre]
      ,[Direccion]
      ,[Rol]
  FROM [ClubCampestre].[dbo].[V_Clientes]
GO

-- Filtrar
CREATE PROCEDURE [dbo].[sp_search_V_Clientes]
(
	@IdCliente smallint, @TipoCliente varchar (20),
	@IdPersona varchar (20), @Nombre varchar (50),
	@Direccion varchar (150), @Rol varchar (15)
)
AS
IF @IdCliente = -32768
BEGIN
	SET @IdCliente = null
END
IF @TipoCliente = ''
BEGIN
	SET @TipoCliente = null
END
IF @IdPersona = ''
BEGIN
	SET @IdPersona = null
END
IF @Nombre = ''
BEGIN
	SET @Nombre = null
END
IF @Direccion = ''
BEGIN
	SET @Direccion = null
END
IF @Rol = ''
BEGIN
	SET @Rol = null
END
SELECT [IdCliente]
      ,[Tipo de Cliente]
      ,[IdPersona]
      ,[Nombre]
      ,[Direccion]
      ,[Rol]
  FROM [ClubCampestre].[dbo].[V_Clientes]
  WHERE [IdCliente] = ISNULL(@IdCliente,[IdCliente])
  AND [Tipo de Cliente] LIKE '%' + ISNULL(@TipoCliente,[Tipo de Cliente]) + '%'
  AND [IdPersona] LIKE '%' + ISNULL(@IdPersona,[IdPersona]) + '%'
  AND [Nombre] LIKE '%' + ISNULL(@Nombre,[Nombre]) + '%'
  AND [Direccion] LIKE '%' + ISNULL(@Direccion,[Direccion]) + '%'
  AND [Rol] LIKE '%' + ISNULL(@Rol,[Rol]) + '%'
GO


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

--V_Usuario
CREATE PROCEDURE [dbo].[sp_select_V_Usuarios]
AS
SELECT [Usuario]
      ,[Identificacion]
      ,[Nombre]
      ,[Rol]
  FROM [dbo].[V_Usuarios]
GO
