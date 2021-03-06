--Select
create procedure [dbo].[sp_select_TB_Rol]
as
select [IdRol] ,[Descripcion] from [dbo].[TB_Rol]
go
--Insert
create procedure [dbo].[sp_insert_TB_Rol]
(
	@Descripcion varchar (15)
)
as
IF NOT EXISTS (SELECT [Descripcion]
                  FROM [dbo].[TB_Rol]
                  WHERE [Descripcion] = @Descripcion)
   BEGIN
       INSERT INTO [dbo].[TB_Rol]
			([Descripcion])
       VALUES (@Descripcion)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdRol])
  FROM [dbo].[TB_Rol]
go
--Update
create procedure [dbo].[sp_update_TB_Rol]
(
	@IdRol tinyint ,@Descripcion varchar (15)
)
as
update [dbo].[TB_Rol]
   set
[Descripcion] = @Descripcion
 where [IdRol] = @IdRol
go
--Delete
create procedure [dbo].[sp_delete_TB_Rol]
(
	@IdRol tinyint
)
as
delete from [dbo].[TB_Rol]
where [IdRol] = @IdRol
go
-- Filtrar
create procedure [dbo].[sp_search_TB_Rol]
(
	@IdRol tinyint ,@Descripcion varchar (15)
)
as
IF @IdRol = 0
BEGIN
	SET @IdRol = null
END
SELECT [IdRol] ,[Descripcion]
  FROM [dbo].[TB_Rol]
  WHERE [IdRol] = ISNULL(@IdRol, [IdRol])
AND [Descripcion] LIKE '%' + ISNULL(@Descripcion, [Descripcion]) + '%'
go