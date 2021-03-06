--Select
create procedure [dbo].[sp_select_TB_Ingresos]
as
select [IdIngreso] ,[IdCliente] ,[IdMembresia] ,[Fecha] from [dbo].[TB_Ingresos]
go
--Insert
create procedure [dbo].[sp_insert_TB_Ingresos]
(
	@IdCliente smallint ,@IdMembresia int ,@Fecha datetime
)
as
IF NOT EXISTS (SELECT [IdIngreso]
                  FROM [dbo].[TB_Ingresos]
                  WHERE [IdCliente] = @IdCliente
AND [IdMembresia] = @IdMembresia)
   BEGIN
       INSERT INTO [dbo].[TB_Ingresos]
			([IdCliente] ,[IdMembresia] ,[Fecha])
       VALUES (@IdCliente ,@IdMembresia ,@Fecha)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdIngreso])
  FROM [dbo].[TB_Ingresos]
go
--Update
create procedure [dbo].[sp_update_TB_Ingresos]
(
	@IdIngreso int ,@IdCliente smallint ,@IdMembresia int ,@Fecha datetime
)
as
update [dbo].[TB_Ingresos]
   set
      [IdCliente] = @IdCliente
,[IdMembresia] = @IdMembresia
,[Fecha] = @Fecha
 where [IdIngreso] = @IdIngreso
go
--Delete
create procedure [dbo].[sp_delete_TB_Ingresos]
(
	@IdIngreso int
)
as
delete from [dbo].[TB_Ingresos]
where [IdIngreso] = @IdIngreso
go
-- Filtrar
create procedure [dbo].[sp_search_TB_Ingresos]
(
	@IdIngreso int ,@IdCliente smallint ,@IdMembresia int
)
as
SELECT [IdIngreso] ,[IdCliente] ,[IdMembresia] ,[Fecha]
  FROM [dbo].[TB_Ingresos]
  WHERE [IdIngreso] = ISNULL(@IdIngreso, [IdIngreso])
AND [IdCliente] = ISNULL(@IdCliente, [IdCliente])
AND [IdMembresia] = ISNULL(@IdMembresia, [IdMembresia])
go
