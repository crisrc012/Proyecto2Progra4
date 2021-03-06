--Select
create procedure [dbo].[sp_select_Tb_Facturacion]
as
select [IdFactura] ,[IdCliente] ,[Descripcion] ,[Fecha] ,[Montototal] from [dbo].[Tb_Facturacion]
go
--Insert
create procedure [dbo].[sp_insert_Tb_Facturacion]
(
	@IdFactura int ,@IdCliente smallint ,@Descripcion varchar (150) ,@Fecha datetime ,@Montototal float
)
as
IF NOT EXISTS (SELECT [IdFactura] ,[IdCliente] ,[Descripcion] ,[Fecha] ,[Montototal]
                  FROM [dbo].[Tb_Facturacion]
                  WHERE [IdFactura] = @IdFactura
AND [IdCliente] = @IdCliente
AND [Descripcion] = @Descripcion
AND [Fecha] = @Fecha
AND [Montototal] = @Montototal)
   BEGIN
       INSERT INTO [dbo].[Tb_Facturacion]
			([IdFactura] ,[IdCliente] ,[Descripcion] ,[Fecha] ,[Montototal])
       VALUES (@IdFactura ,@IdCliente ,@Descripcion ,@Fecha ,@Montototal)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdFactura])
  FROM [dbo].[Tb_Facturacion]
go
--Update
create procedure [dbo].[sp_update_Tb_Facturacion]
(
	@IdFactura int ,@IdCliente smallint ,@Descripcion varchar (150) ,@Fecha datetime ,@Montototal float
)
as
update [dbo].[Tb_Facturacion]
   set
      [IdCliente] = @IdCliente
,[Descripcion] = @Descripcion
,[Fecha] = @Fecha
,[Montototal] = @Montototal
 where [IdFactura] = @IdFactura
go
--Delete
create procedure [dbo].[sp_delete_Tb_Facturacion]
(
	@IdFactura int
)
as
delete from [dbo].[Tb_Facturacion]
where [IdFactura] = @IdFactura
go
-- Filtrar
create procedure [dbo].[sp_search_Tb_Facturacion]
(
	@IdFactura int ,@IdCliente smallint ,@Descripcion varchar (150) ,@Fecha datetime ,@Montototal float
)
as
SELECT [IdFactura] ,[IdCliente] ,[Descripcion] ,[Fecha] ,[Montototal]
  FROM [dbo].[Tb_Facturacion]
  WHERE [IdFactura] LIKE '%' + ISNULL(@IdFactura, [IdFactura]) + '%'
AND [IdCliente] LIKE '%' + ISNULL(@IdCliente, [IdCliente]) + '%'
AND [Descripcion] LIKE '%' + ISNULL(@Descripcion, [Descripcion]) + '%'
AND [Fecha] LIKE '%' + ISNULL(@Fecha, [Fecha]) + '%'
AND [Montototal] LIKE '%' + ISNULL(@Montototal, [Montototal]) + '%'
go
