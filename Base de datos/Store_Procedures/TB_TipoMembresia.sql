--Select
create procedure [dbo].[sp_select_TB_TipoMembresia]
as
select [IdTipoMembresia] ,[Descripcion] ,[costo] from [dbo].[TB_TipoMembresia]
go
--Insert
create procedure [dbo].[sp_insert_TB_TipoMembresia]
(
	@Descripcion varchar (20) ,@costo float
)
as
IF NOT EXISTS (SELECT [Descripcion] ,[costo]
                  FROM [dbo].[TB_TipoMembresia]
                  WHERE [Descripcion] = @Descripcion
AND [costo] = @costo)
   BEGIN
       INSERT INTO [dbo].[TB_TipoMembresia]
			([Descripcion] ,[costo])
       VALUES (@Descripcion ,@costo)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdTipoMembresia])
  FROM [dbo].[TB_TipoMembresia]
GO
--Update
create procedure [dbo].[sp_update_TB_TipoMembresia]
(
	@IdTipoMembresia tinyint ,@Descripcion varchar (20) ,@costo float
)
as
update [dbo].[TB_TipoMembresia]
   set
      [Descripcion] = @Descripcion
,[costo] = @costo
 where [IdTipoMembresia] = @IdTipoMembresia
go
--Delete
create procedure [dbo].[sp_delete_TB_TipoMembresia]
(
	@IdTipoMembresia tinyint
)
as
delete from [dbo].[TB_TipoMembresia]
where [IdTipoMembresia] = @IdTipoMembresia
go
-- Filtrar
create procedure [dbo].[sp_search_TB_TipoMembresia]
(
	@IdTipoMembresia tinyint ,@Descripcion varchar (20) ,@costo float
)
as
IF @IdTipoMembresia = 0
BEGIN
	SET @IdTipoMembresia = null
END
IF @costo = 0
BEGIN
	SET @costo = null
END
SELECT [IdTipoMembresia] ,[Descripcion] ,[costo]
  FROM [dbo].[TB_TipoMembresia]
  WHERE [IdTipoMembresia] = ISNULL(@IdTipoMembresia, [IdTipoMembresia])
AND [Descripcion] LIKE '%' + ISNULL(@Descripcion, [Descripcion]) + '%'
AND [costo] = ISNULL(@costo, [costo])
GO
