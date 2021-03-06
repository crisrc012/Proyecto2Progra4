--Select
create procedure [dbo].[sp_select_TB_Clientes]
as
select [IdCliente] ,[IdTipoCliente] ,[IdPersona] from [dbo].[TB_Clientes]
go
--Insert
create procedure [dbo].[sp_insert_TB_Clientes]
(
	@IdTipoCliente tinyint ,@IdPersona varchar (20)
)
as
IF NOT EXISTS (SELECT [IdPersona]
                  FROM [dbo].[TB_Clientes]
                  WHERE [IdPersona] = @IdPersona)
   BEGIN
       INSERT INTO [dbo].[TB_Clientes]
			([IdTipoCliente] ,[IdPersona])
       VALUES (@IdTipoCliente ,@IdPersona)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdCliente])
  FROM [dbo].[TB_Clientes]
go
--Update
create procedure [dbo].[sp_update_TB_Clientes]
(
	@IdCliente smallint ,@IdTipoCliente tinyint ,@IdPersona varchar (20)
)
as
update [dbo].[TB_Clientes]
   set
      [IdTipoCliente] = @IdTipoCliente
,[IdPersona] = @IdPersona
 where [IdCliente] = @IdCliente
go
--Delete
create procedure [dbo].[sp_delete_TB_Clientes]
(
	@IdCliente smallint
)
as
delete from [dbo].[TB_Clientes]
where [IdCliente] = @IdCliente
go
-- Filtrar
create procedure [dbo].[sp_search_TB_Clientes]
(
	@IdCliente smallint ,@IdTipoCliente tinyint ,@IdPersona varchar (20)
)
as
IF @IdCliente = -32768
BEGIN
	SET @IdCliente = null
END
IF @IdTipoCliente = 0
BEGIN
	SET @IdTipoCliente = null
END
IF @IdPersona = ''
BEGIN
	SET @IdPersona = null
END
SELECT [IdCliente] ,[IdTipoCliente] ,[IdPersona]
  FROM [dbo].[TB_Clientes]
  WHERE [IdCliente] = ISNULL(@IdCliente, [IdCliente])
AND [IdTipoCliente] = ISNULL(@IdTipoCliente, [IdTipoCliente])
AND [IdPersona] LIKE '%' + ISNULL(@IdPersona, [IdPersona]) + '%'
go
