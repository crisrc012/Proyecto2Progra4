--Select
create procedure [dbo].[sp_select_TB_Servicio]
as
select [IdServicio] ,[IdCliente] ,[IdEstado] ,[IdTipoServicio] from [dbo].[TB_Servicio]
go
--Insert
create procedure [dbo].[sp_insert_TB_Servicio]
(
	@IdServicio smallint ,@IdCliente smallint ,@IdEstado char (1) ,@IdTipoServicio tinyint
)
as
IF NOT EXISTS (SELECT [IdServicio] ,[IdCliente] ,[IdEstado] ,[IdTipoServicio]
                  FROM [dbo].[TB_Servicio]
                  WHERE [IdServicio] = @IdServicio
AND [IdCliente] = @IdCliente
AND [IdEstado] = @IdEstado
AND [IdTipoServicio] = @IdTipoServicio)
   BEGIN
       INSERT INTO [dbo].[TB_Servicio]
			([IdServicio] ,[IdCliente] ,[IdEstado] ,[IdTipoServicio])
       VALUES (@IdServicio ,@IdCliente ,@IdEstado ,@IdTipoServicio)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdServicio])
  FROM [dbo].[TB_Servicio]
go
--Update
create procedure [dbo].[sp_update_TB_Servicio]
(
	@IdServicio smallint ,@IdCliente smallint ,@IdEstado char (1) ,@IdTipoServicio tinyint
)
as
update [dbo].[TB_Servicio]
   set
      [IdCliente] = @IdCliente
,[IdEstado] = @IdEstado
,[IdTipoServicio] = @IdTipoServicio
 where [IdServicio] = @IdServicio
 -- Devuelve la ultima llave generada
  SELECT MAX ([IdServicio])
  FROM [dbo].[TB_Servicio]
go
--Delete
create procedure [dbo].[sp_delete_TB_Servicio]
(
	@IdServicio smallint
)
as
delete from [dbo].[TB_Servicio]
where [IdServicio] = @IdServicio
go
-- Filtrar
create procedure [dbo].[sp_search_TB_Servicio]
(
	@IdServicio smallint ,@IdCliente smallint ,@IdEstado char (1) ,@IdTipoServicio tinyint
)
as
SELECT [IdServicio] ,[IdCliente] ,[IdEstado] ,[IdTipoServicio]
  FROM [dbo].[TB_Servicio]
  WHERE [IdServicio] LIKE '%' + ISNULL(@IdServicio, [IdServicio]) + '%'
AND [IdCliente] LIKE '%' + ISNULL(@IdCliente, [IdCliente]) + '%'
AND [IdEstado] LIKE '%' + ISNULL(@IdEstado, [IdEstado]) + '%'
AND [IdTipoServicio] LIKE '%' + ISNULL(@IdTipoServicio, [IdTipoServicio]) + '%'
go
