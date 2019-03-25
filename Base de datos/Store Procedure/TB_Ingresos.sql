--Select
create procedure [dbo].[sp_select_TB_Ingresos]
as
select [IdIngreso] ,[IdCliente] ,[IdMembresia] ,[Fecha] from [dbo].[TB_Ingresos]
go
--Insert
create procedure [dbo].[sp_insert_TB_Ingresos]
(
	@IdIngreso int ,@IdCliente smallint ,@IdMembresia int ,@Fecha datetime
)
as
IF NOT EXISTS (SELECT [IdIngreso] ,[IdCliente] ,[IdMembresia] ,[Fecha]
                  FROM [dbo].[TB_Ingresos]
                  WHERE [IdIngreso] = @IdIngreso
AND [IdCliente] = @IdCliente
AND [IdMembresia] = @IdMembresia
AND [Fecha] = @Fecha)
   BEGIN
       INSERT INTO [dbo].[TB_Ingresos]
			([IdIngreso] ,[IdCliente] ,[IdMembresia] ,[Fecha])
       VALUES (@IdIngreso ,@IdCliente ,@IdMembresia ,@Fecha)
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
 -- Devuelve la ultima llave generada
  SELECT MAX ([IdIngreso])
  FROM [dbo].[TB_Ingresos]
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
	@IdIngreso int ,@IdCliente smallint ,@IdMembresia int ,@Fecha datetime
)
as
SELECT [IdIngreso] ,[IdCliente] ,[IdMembresia] ,[Fecha]
  FROM [dbo].[TB_Ingresos]
  WHERE [IdIngreso] LIKE '%' + ISNULL(@IdIngreso, [IdIngreso]) + '%'
AND [IdCliente] LIKE '%' + ISNULL(@IdCliente, [IdCliente]) + '%'
AND [IdMembresia] LIKE '%' + ISNULL(@IdMembresia, [IdMembresia]) + '%'
AND [Fecha] LIKE '%' + ISNULL(@Fecha, [Fecha]) + '%'
go
