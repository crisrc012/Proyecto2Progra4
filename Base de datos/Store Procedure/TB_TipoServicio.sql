--Select
create procedure [dbo].[sp_select_TB_TipoServicio]
as
select [IdTipoServicio] ,[Descripcion] ,[costo] from [dbo].[TB_TipoServicio]
go
--Insert
create procedure [dbo].[sp_insert_TB_TipoServicio]
(
	@IdTipoServicio tinyint ,@Descripcion varchar (20) ,@costo float
)
as
IF NOT EXISTS (SELECT [IdTipoServicio] ,[Descripcion] ,[costo]
                  FROM [dbo].[TB_TipoServicio]
                  WHERE [IdTipoServicio] = @IdTipoServicio
AND [Descripcion] = @Descripcion
AND [costo] = @costo)
   BEGIN
       INSERT INTO [dbo].[TB_TipoServicio]
			([IdTipoServicio] ,[Descripcion] ,[costo])
       VALUES (@IdTipoServicio ,@Descripcion ,@costo)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdTipoServicio])
  FROM [dbo].[TB_TipoServicio]
go
--Update
create procedure [dbo].[sp_update_TB_TipoServicio]
(
	@IdTipoServicio tinyint ,@Descripcion varchar (20) ,@costo float
)
as
update [dbo].[TB_TipoServicio]
   set
      [Descripcion] = @Descripcion
,[costo] = @costo
 where [IdTipoServicio] = @IdTipoServicio
 -- Devuelve la ultima llave generada
  SELECT MAX ([IdTipoServicio])
  FROM [dbo].[TB_TipoServicio]
go
--Delete
create procedure [dbo].[sp_delete_TB_TipoServicio]
(
	@IdTipoServicio tinyint
)
as
delete from [dbo].[TB_TipoServicio]
where [IdTipoServicio] = @IdTipoServicio
go
-- Filtrar
create procedure [dbo].[sp_search_TB_TipoServicio]
(
	@IdTipoServicio tinyint ,@Descripcion varchar (20) ,@costo float
)
as
SELECT [IdTipoServicio] ,[Descripcion] ,[costo]
  FROM [dbo].[TB_TipoServicio]
  WHERE [IdTipoServicio] LIKE '%' + ISNULL(@IdTipoServicio, [IdTipoServicio]) + '%'
AND [Descripcion] LIKE '%' + ISNULL(@Descripcion, [Descripcion]) + '%'
AND [costo] LIKE '%' + ISNULL(@costo, [costo]) + '%'
go
