--Select
create procedure [dbo].[sp_select_TB_TipoCliente]
as
select [IdTipoCliente] ,[Descripcion] from [dbo].[TB_TipoCliente]
go
--Insert
create procedure [dbo].[sp_insert_TB_TipoCliente]
(
	@Descripcion varchar (20)
)
as
IF NOT EXISTS (SELECT [Descripcion]
                  FROM [dbo].[TB_TipoCliente]
                  WHERE [Descripcion] = @Descripcion)
   BEGIN
       INSERT INTO [dbo].[TB_TipoCliente]
			([Descripcion])
       VALUES (@Descripcion)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdTipoCliente])
  FROM [dbo].[TB_TipoCliente]
go
--Update
create procedure [dbo].[sp_update_TB_TipoCliente]
(
	@IdTipoCliente tinyint ,@Descripcion varchar (20)
)
as
update [dbo].[TB_TipoCliente]
   set
      [Descripcion] = @Descripcion
 where [IdTipoCliente] = @IdTipoCliente
go
--Delete
create procedure [dbo].[sp_delete_TB_TipoCliente]
(
	@IdTipoCliente tinyint
)
as
delete from [dbo].[TB_TipoCliente]
where [IdTipoCliente] = @IdTipoCliente
go
-- Filtrar
create procedure [dbo].[sp_search_TB_TipoCliente]
(
	@IdTipoCliente tinyint ,@Descripcion varchar (20)
)
as
IF @IdTipoCliente = 0
BEGIN
	SET @IdTipoCliente = null
END
SELECT [IdTipoCliente] ,[Descripcion]
  FROM [dbo].[TB_TipoCliente]
  WHERE [IdTipoCliente] = ISNULL(@IdTipoCliente, [IdTipoCliente]) 
AND [Descripcion] LIKE '%' + ISNULL(@Descripcion, [Descripcion]) + '%'
GO
