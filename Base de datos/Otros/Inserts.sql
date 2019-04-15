GO
INSERT INTO [dbo].[TB_TipoCliente] ([Descripcion]) VALUES (N'Básico')
INSERT INTO [dbo].[TB_TipoMembresia] ([Descripcion], [costo]) VALUES (N'Básica', 50)
INSERT INTO [dbo].[TB_Rol] ([Descripcion]) VALUES (N'Administrador')
INSERT INTO [dbo].[TB_Rol] ([Descripcion]) VALUES (N'Operario')
INSERT INTO [dbo].[TB_Persona] ([IdPersona], [Nombre], [Direccion], [IdRol]) VALUES (N'115310065', N'Cristopher Robles Ríos', N'San José', 1)
INSERT INTO [dbo].[TB_Clientes] ([IdTipoCliente], [IdPersona]) VALUES (1, N'115310065')
INSERT INTO [dbo].[TB_Correos] ([IdPersona], [Correo]) VALUES (N'115310065', N'cristopher.robles@uamcr.net')
INSERT INTO [dbo].[TB_Correos] ([IdPersona], [Correo]) VALUES (N'115310065', N'cristopher.robles@uamcr.com')
INSERT INTO [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'A', N'Activo')
INSERT INTO [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'I', N'Inactivo')
INSERT INTO [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'P', N'Pendientes')
INSERT INTO [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'Z', N'Prueba')
--idcliente puede variar
INSERT INTO [dbo].[TB_Membresias] ([IdCliente], [IdTipoMembresia], [IdEstado], [FechaInicio], [FechaVencimiento]) VALUES (1, 1, N'A', CAST(N'2019-04-11' AS Date), CAST(N'2019-04-11' AS Date))
INSERT INTO [dbo].[TB_Telefonos] ([Telefono], [IdPersona]) VALUES (N'22457695', N'115310065')
INSERT INTO [dbo].[TB_Telefonos] ([Telefono], [IdPersona]) VALUES (N'60037072', N'115310065')
INSERT INTO [dbo].[TB_Servicio] ([IdCliente],[IdEstado],[IdTipoServicio],[FechaRegistro]) VALUES (1,'A',1,GETDATE())