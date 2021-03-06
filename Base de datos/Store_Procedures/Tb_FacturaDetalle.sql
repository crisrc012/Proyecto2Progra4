--Select
create procedure [dbo].[sp_select_Tb_FacturaDetalle]
as
select [IdFacturaDetalle] ,[IdFactura] ,[Detalle] ,[costo] ,[IdTipoServicio] ,[IdMembresia] ,[cantidad] ,[total] from [dbo].[Tb_FacturaDetalle]
go
--Insert
create procedure [dbo].[sp_insert_Tb_FacturaDetalle]
(
	@IdFacturaDetalle int ,@IdFactura int ,@Detalle varchar (20) ,@costo float ,@IdTipoServicio tinyint ,@IdMembresia int ,@cantidad int ,@total float
)
as
IF NOT EXISTS (SELECT [IdFacturaDetalle] ,[IdFactura] ,[Detalle] ,[costo] ,[IdTipoServicio] ,[IdMembresia] ,[cantidad] ,[total]
                  FROM [dbo].[Tb_FacturaDetalle]
                  WHERE [IdFacturaDetalle] = @IdFacturaDetalle
AND [IdFactura] = @IdFactura
AND [Detalle] = @Detalle
AND [costo] = @costo
AND [IdTipoServicio] = @IdTipoServicio
AND [IdMembresia] = @IdMembresia
AND [cantidad] = @cantidad
AND [total] = @total)
   BEGIN
       INSERT INTO [dbo].[Tb_FacturaDetalle]
			([IdFacturaDetalle] ,[IdFactura] ,[Detalle] ,[costo] ,[IdTipoServicio] ,[IdMembresia] ,[cantidad] ,[total])
       VALUES (@IdFacturaDetalle ,@IdFactura ,@Detalle ,@costo ,@IdTipoServicio ,@IdMembresia ,@cantidad ,@total)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdFacturaDetalle])
  FROM [dbo].[Tb_FacturaDetalle]
go
--Update
create procedure [dbo].[sp_update_Tb_FacturaDetalle]
(
	@IdFacturaDetalle int ,@IdFactura int ,@Detalle varchar (20) ,@costo float ,@IdTipoServicio tinyint ,@IdMembresia int ,@cantidad int ,@total float
)
as
update [dbo].[Tb_FacturaDetalle]
   set
      [IdFactura] = @IdFactura
,[Detalle] = @Detalle
,[costo] = @costo
,[IdTipoServicio] = @IdTipoServicio
,[IdMembresia] = @IdMembresia
,[cantidad] = @cantidad
,[total] = @total
 where [IdFacturaDetalle] = @IdFacturaDetalle
go
--Delete
create procedure [dbo].[sp_delete_Tb_FacturaDetalle]
(
	@IdFacturaDetalle int
)
as
delete from [dbo].[Tb_FacturaDetalle]
where [IdFacturaDetalle] = @IdFacturaDetalle
go
-- Filtrar
create procedure [dbo].[sp_search_Tb_FacturaDetalle]
(
	@IdFacturaDetalle int ,@IdFactura int ,@Detalle varchar (20) ,@costo float ,@IdTipoServicio tinyint ,@IdMembresia int ,@cantidad int ,@total float
)
as
SELECT [IdFacturaDetalle] ,[IdFactura] ,[Detalle] ,[costo] ,[IdTipoServicio] ,[IdMembresia] ,[cantidad] ,[total]
  FROM [dbo].[Tb_FacturaDetalle]
  WHERE [IdFacturaDetalle] LIKE '%' + ISNULL(@IdFacturaDetalle, [IdFacturaDetalle]) + '%'
AND [IdFactura] LIKE '%' + ISNULL(@IdFactura, [IdFactura]) + '%'
AND [Detalle] LIKE '%' + ISNULL(@Detalle, [Detalle]) + '%'
AND [costo] LIKE '%' + ISNULL(@costo, [costo]) + '%'
AND [IdTipoServicio] LIKE '%' + ISNULL(@IdTipoServicio, [IdTipoServicio]) + '%'
AND [IdMembresia] LIKE '%' + ISNULL(@IdMembresia, [IdMembresia]) + '%'
AND [cantidad] LIKE '%' + ISNULL(@cantidad, [cantidad]) + '%'
AND [total] LIKE '%' + ISNULL(@total, [total]) + '%'
go
