USE [ClubCampestre]
GO

-- TB_Persona - TB_Rol
CREATE VIEW V_Persona AS
SELECT [IdPersona]
      ,[Nombre]
      ,[Direccion]
      ,[ClubCampestre].[dbo].[TB_Rol].[Descripcion]
  FROM [ClubCampestre].[dbo].[TB_Persona]
  JOIN [ClubCampestre].[dbo].[TB_Rol]
  ON [ClubCampestre].[dbo].[TB_Persona].[IdRol] = [ClubCampestre].[dbo].[TB_Rol].[IdRol]
GO

-- TB_Clientes - TB_Persona - TB_Rol - TB_TipoCliente
CREATE VIEW V_Clientes AS
SELECT [IdCliente]
      ,[ClubCampestre].[dbo].[TB_TipoCliente].[Descripcion] as "Tipo de Cliente"
      ,[ClubCampestre].[dbo].[TB_Clientes].[IdPersona]
      ,[Nombre]
      ,[Direccion]
      ,[ClubCampestre].[dbo].[TB_Rol].[Descripcion] as 'Rol'
  FROM [ClubCampestre].[dbo].[TB_Clientes]
  JOIN [ClubCampestre].[dbo].[TB_Persona]
  ON [ClubCampestre].[dbo].[TB_Clientes].[IdPersona] = [ClubCampestre].[dbo].[TB_Persona].[IdPersona]
  JOIN [ClubCampestre].[dbo].[TB_Rol]
  ON [ClubCampestre].[dbo].[TB_Persona].[IdRol] = [ClubCampestre].[dbo].[TB_Rol].[IdRol]
  JOIN [ClubCampestre].[dbo].[TB_TipoCliente]
  ON [ClubCampestre].[dbo].[TB_Clientes].[IdTipoCliente] = [ClubCampestre].[dbo].[TB_TipoCliente].[IdTipoCliente]
GO
  
-- TB_Membresias - V_Clientes - TB_TipoMembresia - TB_Estado
CREATE VIEW V_Membresias AS
SELECT [IdMembresia]
      ,[dbo].[V_Clientes].[IdPersona] AS 'Identificación'
	  ,[dbo].[V_Clientes].[Nombre]
      ,[dbo].[TB_TipoMembresia].[Descripcion] AS 'Membresía'
	  ,[dbo].[TB_TipoMembresia].[costo] AS 'Costo'
      ,[dbo].[TB_Estado].[Estado]
      ,[FechaInicio]
      ,[FechaVencimiento]
  FROM [dbo].[TB_Membresias]
  JOIN [dbo].[V_Clientes]
  ON [dbo].[TB_Membresias].[IdCliente] = [dbo].[V_Clientes].[IdCliente]
  JOIN [dbo].[TB_TipoMembresia]
  ON [dbo].[TB_TipoMembresia].[IdTipoMembresia] = [dbo].[TB_Membresias].[IdTipoMembresia]
  JOIN [dbo].[TB_Estado]
  ON [dbo].[TB_Estado].[IdEstado] = [dbo].[TB_Membresias].[IdEstado]
GO
