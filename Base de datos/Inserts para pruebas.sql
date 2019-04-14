
SET IDENTITY_INSERT [dbo].[TB_Clientes] ON 
GO
INSERT [dbo].[TB_Clientes] ([IdCliente], [IdTipoCliente], [IdPersona]) VALUES (1, 1, N'115310065')
GO
SET IDENTITY_INSERT [dbo].[TB_Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_Correos] ON 
GO
INSERT [dbo].[TB_Correos] ([IdCorreo], [IdPersona], [Correo]) VALUES (1, N'115310065', N'cristopher.robles@uamcr.net')
GO
INSERT [dbo].[TB_Correos] ([IdCorreo], [IdPersona], [Correo]) VALUES (2, N'115310065', N'cristopher.robles@uamcr.com')
GO
SET IDENTITY_INSERT [dbo].[TB_Correos] OFF
GO
INSERT [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'A', N'Activo')
GO
INSERT [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'I', N'Inactivo')
GO
INSERT [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'P', N'Pendientes')
GO
INSERT [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'Z', N'Prueba')
GO
SET IDENTITY_INSERT [dbo].[TB_Membresias] ON 
GO
INSERT [dbo].[TB_Membresias] ([IdMembresia], [IdCliente], [IdTipoMembresia], [IdEstado], [FechaInicio], [FechaVencimiento]) VALUES (1, 1, 1, N'A', CAST(N'2019-04-11' AS Date), CAST(N'2019-04-11' AS Date))
GO
SET IDENTITY_INSERT [dbo].[TB_Membresias] OFF
GO
INSERT [dbo].[TB_Persona] ([IdPersona], [Nombre], [Direccion], [IdRol]) VALUES (N'115310065', N'Cristopher Robles Ríos', N'San José', 1)
GO
SET IDENTITY_INSERT [dbo].[TB_Rol] ON 
GO
INSERT [dbo].[TB_Rol] ([IdRol], [Descripcion]) VALUES (1, N'Administrador')
GO
INSERT [dbo].[TB_Rol] ([IdRol], [Descripcion]) VALUES (2, N'Operario')
GO
SET IDENTITY_INSERT [dbo].[TB_Rol] OFF
GO
INSERT [dbo].[TB_Telefonos] ([Telefono], [IdPersona]) VALUES (N'22457695', N'115310065')
GO
INSERT [dbo].[TB_Telefonos] ([Telefono], [IdPersona]) VALUES (N'60037072', N'115310065')
GO
SET IDENTITY_INSERT [dbo].[TB_TipoCliente] ON 
GO
INSERT [dbo].[TB_TipoCliente] ([IdTipoCliente], [Descripcion]) VALUES (1, N'Básico')
GO
SET IDENTITY_INSERT [dbo].[TB_TipoCliente] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_TipoMembresia] ON 
GO
INSERT [dbo].[TB_TipoMembresia] ([IdTipoMembresia], [Descripcion], [costo]) VALUES (1, N'Básica', 50)
GO
