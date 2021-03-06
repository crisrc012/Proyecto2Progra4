--Select
create procedure [dbo].[sp_select_TB_Usuarios]
as
select [IdUsuario] ,[IdPersona] ,[Contrasena] from [dbo].[TB_Usuarios]
go
--Insert
create procedure [dbo].[sp_insert_TB_Usuarios]
(
	@IdUsuario varchar (25) ,@IdPersona varchar (20) ,@Contrasena varchar (50)
)
as
IF NOT EXISTS (SELECT [IdUsuario] ,[IdPersona] ,[Contrasena]
                  FROM [dbo].[TB_Usuarios]
                  WHERE [IdUsuario] = @IdUsuario
AND [IdPersona] = @IdPersona
AND [Contrasena] = @Contrasena)
   BEGIN
       INSERT INTO [dbo].[TB_Usuarios]
			([IdUsuario] ,[IdPersona] ,[Contrasena])
       VALUES (@IdUsuario ,@IdPersona ,@Contrasena)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdUsuario])
  FROM [dbo].[TB_Usuarios]
go
--Update
create procedure [dbo].[sp_update_TB_Usuarios]
(
	@IdUsuario varchar (25) ,@IdPersona varchar (20) ,@Contrasena varchar (50)
)
as
update [dbo].[TB_Usuarios]
   set
      [IdUsuario] = @IdUsuario
,[IdPersona] = @IdPersona
,[Contrasena] = @Contrasena
 where [IdUsuario] = @IdUsuario
go
--Delete
create procedure [dbo].[sp_delete_TB_Usuarios]
(
	@IdUsuario varchar (25)
)
as
delete from [dbo].[TB_Usuarios]
where [IdUsuario] = @IdUsuario
go
-- Filtrar
create procedure [dbo].[sp_search_TB_Usuarios]
(
	@IdUsuario varchar (25) ,@IdPersona varchar (20) ,@Contrasena varchar (50)
)
as
SELECT [IdUsuario] ,[IdPersona] ,[Contrasena]
  FROM [dbo].[TB_Usuarios]
  WHERE [IdUsuario] LIKE '%' + ISNULL(@IdUsuario, [IdUsuario]) + '%'
AND [IdPersona] LIKE '%' + ISNULL(@IdPersona, [IdPersona]) + '%'
AND [Contrasena] LIKE '%' + ISNULL(@Contrasena, [Contrasena]) + '%'
go
