use master
go

create database [ClubCampestre]
go

use ClubCampestre
go

create table TB_Persona (
		IdPersona varchar (20) not null,--PK
		Nombre varchar (50) not null, 
		Direccion varchar (150) not null,
		IdRol tinyint not null,--FK
		constraint [PK_IdPersona] primary key clustered(
					IdPersona asc
		)
)
go


create table TB_Usuarios (
		IdUsuario varchar (6) not null,--PK
		IdPersona varchar (20) not null, 
		Contrasena varchar (10) not null,
		constraint [PK_IdUsuario] primary key clustered(
					IdUsuario asc
		)
)
go

create table TB_Rol (
		IdRol tinyint  identity (1,1) not null,--PK
		Descripcion varchar (15) not null,
		constraint [PK_IdRol] primary key clustered(
					IdRol asc
		)
)
go

create table TB_Correos (
		IdCorreo smallint identity (1,1) not null,--PK
		IdPersona varchar (20) not null, --FK
		Correo varchar (60) not null,
		constraint [PK_IdCorreo] primary key clustered(
					IdCorreo asc
		)
)
go


create table TB_Telefonos (
		Telefono varchar (10) not null,--PK
		IdPersona varchar (20) not null, --FK
		constraint [PK_Telefono] primary key clustered(
					Telefono asc
		)
)
go


create table TB_TipoCliente (
		IdTipoCliente tinyint identity (1,1) not null,--PK
		Descripcion varchar (20) not null,
		constraint [PK_IdTipoCliente] primary key clustered(
					IdTipoCliente asc
		)
)
go


create table TB_Clientes (
		IdCliente smallint identity (1,1) not null,--PK
		IdTipoCliente tinyint not null,--FK
		IdPersona varchar (20) not null,--FK
		constraint [PK_IdCliente] primary key clustered(
					IdCliente asc
		)
)
go

create table TB_Beneficiarios (
		IdBeneficiario smallint identity (1,1) not null,--PK
		IdCliente smallint not null,--FK
		IdPersona varchar (20) not null,--FK
		IdEstado char (1) not null--FK
		constraint [PK_IdBeneficiario] primary key clustered(
					IdBeneficiario  asc
		)
)
go

create table TB_Estado (
		IdEstado char (1)  not null,--PK
		Estado varchar (15) not null, 
		constraint [PK_IdEstado] primary key clustered(
					IdEstado asc
		)
)
go


create table TB_TipoServicio (
		IdTipoServicio tinyint identity (1,1) not null,--PK
		Descripcion varchar (20) not null, 
		costo float not null,
		constraint [PK_IdTipoServicio] primary key clustered(
					IdTipoServicio asc
		)
)
go

create table TB_Servicio (
		IdServicio smallint identity (1,1) not null,--PK
		IdCliente smallint not null,--FK
		IdEstado char (1) not null,--FK
		IdTipoServicio tinyint not null,--FK
		constraint [PK_IdServicio] primary key clustered(
					IdServicio asc
		)
)
go


create table TB_TipoMembresia (
		IdTipoMembresia tinyint identity (1,1) not null,--PK
		Descripcion varchar (20) not null, 
		costo float not null,
		constraint [PK_IdTipoMembresia] primary key clustered(
					IdTipoMembresia asc
		)
)
go


create table TB_Membresias (
		IdMembresia int  identity (1,1) not null,--PK
		IdCliente smallint not null,--FK
		IdTipoMembresia tinyint not null,--FK
		IdEstado char (1) not null,--FK
		FechaInicio date not null,
		FechaVencimiento date not null,
		constraint [PK_IdMembresia] primary key clustered(
					IdMembresia asc
		)
)
go



create table TB_Ingresos (
		IdIngreso int identity (1,1) not null,--PK
		IdCliente smallint not null,--FK
		IdMembresia int null,--FK
		Fecha datetime not null
		constraint [PK_IdIngreso] primary key clustered(
					IdIngreso asc
		)
)
go




create table Tb_Facturacion (
		IdFactura int identity (1,1) not null,--PK
		IdCliente smallint not null,--FK
		Descripcion varchar (150) not null,
		Fecha datetime not null,
		Montototal float not null,
		constraint [PK_IdFactura] primary key clustered(
					IdFactura asc
		)
)


create table Tb_FacturaDetalle (
		IdFacturaDetalle int identity (1,1) not null,--PK
		IdFactura int not null,---FK
		Detalle varchar (20) not null,
		costo float not null,
		IdTipoServicio tinyint null, ---FK
		IdMembresia int null,---FK
		cantidad int not null,
		total float not null
		constraint [PK_IdFacturaDetalle] primary key clustered(
					IdFacturaDetalle asc
		)
)
go


-----Foreign Keys-------------
--------TB_Persona----------------------------

alter table [dbo].[TB_Persona] with nocheck 
	add constraint [FK_TB_Persona_TB_Rol_IdRol] foreign key([IdRol])
		references [dbo].[TB_Rol] ([IdRol])
		on update cascade
go

----------------TB_Telefonos------------------------------

alter table [dbo].[TB_Telefonos] with nocheck 
	add constraint [FK_TB_Telefonos_TB_Persona_IdPersona] foreign key([IdPersona])
		references [dbo].[TB_Persona] ([IdPersona])
		on update cascade
go




------------------TB_Correos------------------------------------

alter table [dbo].[TB_Correos] with nocheck 
	add constraint [FK_TB_Correos_TB_Persona_IdPersona] foreign key([IdPersona])
		references [dbo].[TB_Persona] ([IdPersona])
		on update cascade
go

-------Tb_clientes----------------

alter table [dbo].[TB_Clientes] with nocheck 
	add constraint [FK_TB_Clientes_TB_TipoCliente_IdTipoCliente] foreign key([IdTipoCliente])
		references [dbo].[TB_TipoCliente] ([IdTipoCliente])
		on update cascade
go

alter table [dbo].[TB_Clientes] with nocheck 
	add constraint [FK_TB_Clientes_TB_Persona_IdPersona] foreign key([IdPersona])
		references [dbo].[TB_Persona] ([IdPersona])
		on update cascade
go



----------TB_Beneficiarios--------------------------
alter table [dbo].[TB_Beneficiarios] with nocheck 
	add constraint [FK_TB_Beneficiarios_TB_Persona_IdPersona] foreign key([IdPersona])
		references [dbo].[TB_Persona] ([IdPersona])
		on update cascade
go

alter table [dbo].[TB_Beneficiarios] with nocheck 
	add constraint [FK_TB_Beneficiarios_TB_Clientes_IdCliente] foreign key([IdCliente])
		references [dbo].[TB_Clientes] ([IdCliente])
		
go

alter table [dbo].[TB_Beneficiarios] with nocheck 
	add constraint [FK_TB_Beneficiarios_TB_Estado_IdEstado] foreign key([IdEstado])
		references [dbo].[TB_Estado] ([IdEstado])
		on update cascade
go



------------------TB_Servicio----------------------------

alter table [dbo].[TB_Servicio] with nocheck 
	add constraint [FK_TB_Servicio_TB_Clientes_IdCliente] foreign key([IdCliente])
		references [dbo].[TB_Clientes] ([IdCliente])
		on update cascade
go

alter table [dbo].[TB_Servicio] with nocheck 
	add constraint [FK_TB_Servicio_TB_Estado_IdEstado] foreign key([IdEstado])
		references [dbo].[TB_Estado] ([IdEstado])
		on update cascade
go

alter table [dbo].[TB_Servicio] with nocheck 
	add constraint [FK_TB_Servicio_TB_TipoServicio_IdTipoServicio] foreign key([IdTipoServicio])
		references [dbo].[TB_TipoServicio] ([IdTipoServicio])
		on update cascade
go




------------------TB_Membresia----------------------------

alter table [dbo].[TB_Membresias] with nocheck 
	add constraint [FK_TB_Membresia_TB_Clientes_IdCliente] foreign key([IdCliente])
		references [dbo].[TB_Clientes] ([IdCliente])
		
go

alter table [dbo].[TB_Membresias] with nocheck 
	add constraint [FK_TB_Membresia_TB_Estado_IdEstado] foreign key([IdEstado])
		references [dbo].[TB_Estado] ([IdEstado])
		on update cascade
go

alter table [dbo].[TB_Membresias] with nocheck 
	add constraint [FK_TB_Membresia_TB_TipoMembresia_IdTipoMembresia] foreign key([IdTipoMembresia])
		references [dbo].[TB_TipoMembresia] ([IdTipoMembresia])
		on update cascade
go



----------------TB_Ingresos-------------------


alter table [dbo].[TB_Ingresos] with nocheck 
	add constraint [FK_TB_Ingresos_TB_Clientes_IdCliente] foreign key([IdCliente])
		references [dbo].[TB_Clientes] ([IdCliente])
		on update cascade
go


alter table [dbo].[TB_Ingresos] with nocheck 
	add constraint [FK_TB_Ingresos_TB_Membresias_IdMembresia] foreign key([IdMembresia])
		references [dbo].[TB_Membresias] ([IdMembresia])
		on update cascade
go



--------------TB_Facturacion---------------------------


alter table [dbo].[TB_Facturacion] with nocheck 
	add constraint [FK_TB_Facturacion_TB_Clientes_IdCliente] foreign key([IdCliente])
		references [dbo].[TB_Clientes] ([IdCliente])
		on update cascade
go



-------------TB_FacturaDetalle----------------

alter table [dbo].[TB_FacturaDetalle] with nocheck 
	add constraint [FK_TB_FacturaDetalle_TB_Facturacion_IdFactura] foreign key([IdFactura])
		references [dbo].[TB_Facturacion] ([IdFactura])
		on update cascade
go


alter table [dbo].[TB_FacturaDetalle] with nocheck 
	add constraint [FK_TB_FacturaDetalle_TB_Membresias_IdMembresia] foreign key([IdMembresia])
		references [dbo].[TB_Membresias] ([IdMembresia])
		on update cascade
go


alter table [dbo].[TB_FacturaDetalle] with nocheck 
	add constraint [FK_TB_FacturaDetalle_TB_TipoServicio_IdTipoServicio] foreign key([IdTipoServicio])
		references [dbo].[TB_TipoServicio] ([IdTipoServicio])
		on update cascade
go

------------------TB_Usuarios---------------------

alter table [dbo].[TB_Usuarios] with nocheck 
	add constraint [FK_TB_Usuarios_TB_Persona_IdPersona] foreign key([IdPersona])
		references [dbo].[TB_Persona] ([IdPersona])
		on update cascade
go