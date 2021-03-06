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
	@IdMembresia int ,@IdCliente smallint ,@IdTipoMembresia tinyint
)
as
IF @IdCliente = -32768
BEGIN
	SET @IdCliente = null
END
IF @IdTipoMembresia = 0
BEGIN
	SET @IdTipoMembresia = null
END
SELECT [IdMembresia] ,[IdCliente] ,[IdTipoMembresia] ,[IdEstado] ,[FechaInicio] ,[FechaVencimiento]
  FROM [dbo].[TB_Membresias]
  WHERE [IdMembresia] = ISNULL(@IdMembresia, [IdMembresia])
AND [IdCliente] = ISNULL(@IdCliente, [IdCliente])
AND [IdTipoMembresia] = ISNULL(@IdTipoMembresia, [IdTipoMembresia])
go
