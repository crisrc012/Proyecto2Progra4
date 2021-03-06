--Select
create procedure [dbo].[sp_select_TB_TipoServicio]
as
select [IdTipoServicio], [Descripcion] ,[costo] from [dbo].[TB_TipoServicio]
go
--Insert
create procedure [dbo].[sp_insert_TB_TipoServicio]
(
	@Descripcion varchar (20) ,@costo float
)
as
IF NOT EXISTS (SELECT [Descripcion] ,[costo]
                  FROM [dbo].[TB_TipoServicio]
                  WHERE [Descripcion] = @Descripcion)
   BEGIN
       INSERT INTO [dbo].[TB_TipoServicio]
			([Descripcion] ,[costo])
       VALUES (@Descripcion ,@costo)
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
if @IdTipoServicio = 0
begin
	set @IdTipoServicio = null
end
if @Descripcion = ''
begin
	set @Descripcion = null
end
if @costo = 0
begin
	set @costo = null
end
SELECT [IdTipoServicio] ,[Descripcion] ,[costo]
  FROM [dbo].[TB_TipoServicio]
  WHERE [IdTipoServicio] = ISNULL(@IdTipoServicio, [IdTipoServicio])
AND [Descripcion] LIKE '%' + ISNULL(@Descripcion, [Descripcion]) + '%'
AND [costo] = ISNULL(@costo, [costo])
go
