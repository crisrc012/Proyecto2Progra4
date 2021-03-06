--Select
create procedure [dbo].[sp_select_TB_Estado]
as
select [IdEstado] ,[Estado] from [dbo].[TB_Estado]
go
--Insert
create procedure [dbo].[sp_insert_TB_Estado]
(
	@IdEstado char (1) ,@Estado varchar (15)
)
as
IF NOT EXISTS (SELECT [IdEstado]
                  FROM [dbo].[TB_Estado]
                  WHERE [IdEstado] = @IdEstado
AND [Estado] = @Estado)
   BEGIN
       INSERT INTO [dbo].[TB_Estado]
			([IdEstado] ,[Estado])
       VALUES (@IdEstado ,@Estado)
   END
go
--Update
create procedure [dbo].[sp_update_TB_Estado]
(
	@IdEstado char (1) ,@Estado varchar (15)
)
as
update [dbo].[TB_Estado]
   set
      [IdEstado] = @IdEstado
,[Estado] = @Estado
 where [IdEstado] = @IdEstado
go
--Delete
create procedure [dbo].[sp_delete_TB_Estado]
(
	@IdEstado char (1)
)
as
delete from [dbo].[TB_Estado]
where [IdEstado] = @IdEstado
go
-- Filtrar
create procedure [dbo].[sp_search_TB_Estado]
(
	@IdEstado char (1) ,@Estado varchar (15)
)
as
SELECT [IdEstado] ,[Estado]
  FROM [dbo].[TB_Estado]
  WHERE [IdEstado] = ISNULL(@IdEstado, [IdEstado])
AND [Estado] LIKE '%' + ISNULL(@Estado, [Estado]) + '%'
go
