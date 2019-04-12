--Select
create procedure [dbo].[sp_select_TB_Membresias]
as
select [IdMembresia] ,[IdCliente] ,[IdTipoMembresia] ,[IdEstado] ,[FechaInicio] ,[FechaVencimiento] from [dbo].[TB_Membresias]
go
--Insert
create procedure [dbo].[sp_insert_TB_Membresias]
(
	@IdCliente smallint ,@IdTipoMembresia tinyint ,@IdEstado char (1) ,@FechaInicio date ,@FechaVencimiento date
)
as
IF NOT EXISTS (SELECT [IdCliente] ,[IdTipoMembresia]
                  FROM [dbo].[TB_Membresias]
                  WHERE [IdCliente] = @IdCliente
AND [IdTipoMembresia] = @IdTipoMembresia)
   BEGIN
       INSERT INTO [dbo].[TB_Membresias]
			([IdCliente] ,[IdTipoMembresia] ,[IdEstado] ,[FechaInicio] ,[FechaVencimiento])
       VALUES (@IdCliente ,@IdTipoMembresia ,@IdEstado ,@FechaInicio ,@FechaVencimiento)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdMembresia])
  FROM [dbo].[TB_Membresias]
go
--Update
create procedure [dbo].[sp_update_TB_Membresias]
(
	@IdMembresia int ,@IdCliente smallint ,@IdTipoMembresia tinyint ,@IdEstado char (1) ,@FechaInicio date ,@FechaVencimiento date
)
as
update [dbo].[TB_Membresias]
   set
      [IdCliente] = @IdCliente
,[IdTipoMembresia] = @IdTipoMembresia
,[IdEstado] = @IdEstado
,[FechaInicio] = @FechaInicio
,[FechaVencimiento] = @FechaVencimiento
 where [IdMembresia] = @IdMembresia
 -- Devuelve la ultima llave generada
  SELECT MAX ([IdMembresia])
  FROM [dbo].[TB_Membresias]
go
--Delete
create procedure [dbo].[sp_delete_TB_Membresias]
(
	@IdMembresia int
)
as
delete from [dbo].[TB_Membresias]
where [IdMembresia] = @IdMembresia
go
-- Filtrar
create procedure [dbo].[sp_search_TB_Membresias]
(
	@IdMembresia int ,@IdCliente smallint ,@IdTipoMembresia tinyint ,@IdEstado char (1) ,@FechaInicio date ,@FechaVencimiento date
)
as
SELECT [IdMembresia] ,[IdCliente] ,[IdTipoMembresia] ,[IdEstado] ,[FechaInicio] ,[FechaVencimiento]
  FROM [dbo].[TB_Membresias]
  WHERE [IdMembresia] LIKE '%' + ISNULL(@IdMembresia, [IdMembresia]) + '%'
AND [IdCliente] LIKE '%' + ISNULL(@IdCliente, [IdCliente]) + '%'
AND [IdTipoMembresia] LIKE '%' + ISNULL(@IdTipoMembresia, [IdTipoMembresia]) + '%'
AND [IdEstado] LIKE '%' + ISNULL(@IdEstado, [IdEstado]) + '%'
AND [FechaInicio] > ISNULL(@FechaInicio, [FechaInicio])
AND [FechaVencimiento] < ISNULL(@FechaVencimiento, [FechaVencimiento])
go
