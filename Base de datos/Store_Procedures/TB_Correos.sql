--Select
create procedure [dbo].[sp_select_TB_Correos]
as
select [IdCorreo] ,[IdPersona] ,[Correo] from [dbo].[TB_Correos]
go
--Insert
create procedure [dbo].[sp_insert_TB_Correos]
(
	@IdPersona varchar (20) ,@Correo varchar (60)
)
as
IF NOT EXISTS (SELECT [IdCorreo] ,[IdPersona] ,[Correo]
                  FROM [dbo].[TB_Correos]
                  WHERE [Correo] = @Correo)
   BEGIN
       INSERT INTO [dbo].[TB_Correos]
			([IdPersona] ,[Correo])
       VALUES (@IdPersona ,@Correo)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdCorreo])
  FROM [dbo].[TB_Correos]
go
--Update
create procedure [dbo].[sp_update_TB_Correos]
(
	@IdCorreo smallint ,@IdPersona varchar (20) ,@Correo varchar (60)
)
as
update [dbo].[TB_Correos]
   set
[IdPersona] = @IdPersona
,[Correo] = @Correo
 where [IdCorreo] = @IdCorreo
go
--Delete
create procedure [dbo].[sp_delete_TB_Correos]
(
	@IdCorreo smallint
)
as
delete from [dbo].[TB_Correos]
where [IdCorreo] = @IdCorreo
go
-- Filtrar
create procedure [dbo].[sp_search_TB_Correos]
(
	@IdCorreo smallint ,@IdPersona varchar (20) ,@Correo varchar (60)
)
as
SELECT [IdCorreo] ,[IdPersona] ,[Correo]
  FROM [dbo].[TB_Correos]
  WHERE [IdCorreo] LIKE '%' + ISNULL(@IdCorreo, [IdCorreo]) + '%'
AND [IdPersona] LIKE '%' + ISNULL(@IdPersona, [IdPersona]) + '%'
AND [Correo] LIKE '%' + ISNULL(@Correo, [Correo]) + '%'
go
