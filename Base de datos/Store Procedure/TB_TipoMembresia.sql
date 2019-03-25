--Select
create procedure [dbo].[sp_select_TB_TipoMembresia]
as
select [IdTipoMembresia] ,[Descripcion] ,[costo] from [dbo].[TB_TipoMembresia]
go
--Insert
create procedure [dbo].[sp_insert_TB_TipoMembresia]
(
	@IdTipoMembresia tinyint ,@Descripcion varchar (20) ,@costo float
)
as
IF NOT EXISTS (SELECT [IdTipoMembresia] ,[Descripcion] ,[costo]
                  FROM [dbo].[TB_TipoMembresia]
                  WHERE [IdTipoMembresia] = @IdTipoMembresia
AND [Descripcion] = @Descripcion
AND [costo] = @costo)
   BEGIN
       INSERT INTO [dbo].[TB_TipoMembresia]
			([IdTipoMembresia] ,[Descripcion] ,[costo])
       VALUES (@IdTipoMembresia ,@Descripcion ,@costo)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdTipoMembresia])
  FROM [dbo].[TB_TipoMembresia]
go
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
 -- Devuelve la ultima llave generada
  SELECT MAX ([IdTipoMembresia])
  FROM [dbo].[TB_TipoMembresia]
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
SELECT [IdTipoMembresia] ,[Descripcion] ,[costo]
  FROM [dbo].[TB_TipoMembresia]
  WHERE [IdTipoMembresia] LIKE '%' + ISNULL(@IdTipoMembresia, [IdTipoMembresia]) + '%'
AND [Descripcion] LIKE '%' + ISNULL(@Descripcion, [Descripcion]) + '%'
AND [costo] LIKE '%' + ISNULL(@costo, [costo]) + '%'
go
