GO
-- tipo de Cliente 
INSERT INTO [dbo].[TB_TipoCliente] ([Descripcion]) VALUES (N'Socio')
INSERT INTO [dbo].[TB_TipoCliente] ([Descripcion]) VALUES (N'Beneficiario')

---Tipo de Membresia 

INSERT INTO [dbo].[TB_TipoMembresia] ([Descripcion], [costo]) VALUES (N'GOLD', 1000)
INSERT INTO [dbo].[TB_TipoMembresia] ([Descripcion], [costo]) VALUES (N'SILVER', 500)
INSERT INTO [dbo].[TB_TipoMembresia] ([Descripcion], [costo]) VALUES (N'BRONZE', 100)

--- Tipo de Rol 
INSERT INTO [dbo].[TB_Rol] ([Descripcion]) VALUES (N'Administrativo')
INSERT INTO [dbo].[TB_Rol] ([Descripcion]) VALUES (N'Cliente Externo')

-- Personas ingreso de persona administrator  

INSERT INTO [dbo].[TB_Persona] ([IdPersona], [Nombre], [Direccion], [IdRol]) VALUES (N'123', N'Administrator  ', N'San Jose', 1)
INSERT INTO [dbo].[TB_Persona] ([IdPersona], [Nombre], [Direccion], [IdRol]) VALUES (N'115310065', N'Cristopher Robles Ríos', N'San José', 1)
INSERT INTO [dbo].[TB_Persona] ([IdPersona], [Nombre], [Direccion], [IdRol]) VALUES (N'14500535', N'Wilberth Hernandez Nuñez', N'San José', 2)
INSERT INTO [dbo].[TB_Persona] ([IdPersona], [Nombre], [Direccion], [IdRol]) VALUES (N'303790313', N'Marco Gómez Guzman  ', N'Cartago', 2)

--- Tipo de CLiente 

INSERT INTO [dbo].[TB_Clientes] ([IdTipoCliente], [IdPersona]) VALUES (1, N'115310065')
INSERT INTO [dbo].[TB_Clientes] ([IdTipoCliente], [IdPersona]) VALUES (1, N'14500535')
INSERT INTO [dbo].[TB_Clientes] ([IdTipoCliente], [IdPersona]) VALUES (2, N'303790313')

--Correo 

INSERT INTO [dbo].[TB_Correos] ([IdPersona], [Correo]) VALUES (N'115310065', N'cristopher.robles@uamcr.net')
INSERT INTO [dbo].[TB_Correos] ([IdPersona], [Correo]) VALUES (N'115310065', N'cristopher.robles@uamcr.com')
INSERT INTO [dbo].[TB_Correos] ([IdPersona], [Correo]) VALUES (N'114500535', N'whernandez@gmail.com')
INSERT INTO [dbo].[TB_Correos] ([IdPersona], [Correo]) VALUES (N'303790313', N'marco.gomez@uamcr.com')

-- Estado 
INSERT INTO [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'A', N'Activo')
INSERT INTO [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'I', N'Inactivo')
INSERT INTO [dbo].[TB_Estado] ([IdEstado], [Estado]) VALUES (N'P', N'Pendientes')

--idcliente puede variar, si no se elimina la Base de datos

---Membresias por persona 

INSERT INTO [dbo].[TB_Membresias] ([IdCliente], [IdTipoMembresia], [IdEstado], [FechaInicio], [FechaVencimiento]) VALUES (1, 1, N'A', CAST(N'2019-04-11' AS Date), CAST(N'2019-04-11' AS Date))
INSERT INTO [dbo].[TB_Telefonos] ([Telefono], [IdPersona]) VALUES (N'22457695', N'115310065')
INSERT INTO [dbo].[TB_Telefonos] ([Telefono], [IdPersona]) VALUES (N'84119825', N'114500535')
INSERT INTO [dbo].[TB_Telefonos] ([Telefono], [IdPersona]) VALUES (N'72000413', N'303790313')

--- Tipo de servio 

INSERT INTO [dbo].[TB_TipoServicio] ([Descripcion],[costo]) VALUES ('Piscina', 10)
INSERT INTO [dbo].[TB_TipoServicio] ([Descripcion],[costo]) VALUES ('Amplio Gimnasio con SPA y Sauna', 60)
INSERT INTO [dbo].[TB_TipoServicio] ([Descripcion],[costo]) VALUES ('Canchas para distintos deportes', 15)
INSERT INTO [dbo].[TB_TipoServicio] ([Descripcion],[costo]) VALUES ('Cabañas', 60)
INSERT INTO [dbo].[TB_TipoServicio] ([Descripcion],[costo]) VALUES ('Ranchos para fiestas BBQ', 10)
INSERT INTO [dbo].[TB_TipoServicio] ([Descripcion],[costo]) VALUES ('Salón de eventos', 300)
INSERT INTO [dbo].[TB_TipoServicio] ([Descripcion],[costo]) VALUES ('Almuerzo Buffet.', 25)

---Servicio Relacionado a un cliente 


INSERT INTO [dbo].[TB_Servicio] ([IdCliente],[IdEstado],[IdTipoServicio],[FechaRegistro]) VALUES (1,'A',1,GETDATE())


-- inserte de administrador como usuario pendiente 

--INSERT INTO [dbo].[TB_Usuarios] ([IdPersona]),[Contrasena]) VALUES ('123','Abc12345')





GO
