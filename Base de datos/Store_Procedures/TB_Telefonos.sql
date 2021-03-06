--Select
create procedure [dbo].[sp_select_TB_Telefonos]
as
select [Telefono] ,[IdPersona] from [dbo].[TB_Telefonos]
go
--Insert
create procedure [dbo].[sp_insert_TB_Telefonos]
(
	@Telefono varchar (10) ,@IdPersona varchar (20)
)
as
IF NOT EXISTS (SELECT [Telefono] ,[IdPersona]
                  FROM [dbo].[TB_Telefonos]
                  WHERE [Telefono] = @Telefono
AND [IdPersona] = @IdPersona)
   BEGIN
       INSERT INTO [dbo].[TB_Telefonos]
			([Telefono] ,[IdPersona])
       VALUES (@Telefono ,@IdPersona)
   END
go
--Update
create procedure [dbo].[sp_update_TB_Telefonos]
(
	@Telefono varchar (10) ,@IdPersona varchar (20)
)
as
update [dbo].[TB_Telefonos]
   set
      [Telefono] = @Telefono
,[IdPersona] = @IdPersona
 where [Telefono] = @Telefono
go
--Delete
create procedure [dbo].[sp_delete_TB_Telefonos]
(
	@Telefono varchar (10) ,@IdPersona varchar (20)
)
as
if @Telefono <> ''
begin
	delete from [dbo].[TB_Telefonos]
	where [Telefono] = @Telefono
end
if @IdPersona <> ''
begin
	delete from [dbo].[TB_Telefonos]
	where [IdPersona] = @IdPersona
end

go
-- Filtrar
create procedure [dbo].[sp_search_TB_Telefonos]
(
	@Telefono varchar (10) ,@IdPersona varchar (20)
)
as
SELECT [Telefono] ,[IdPersona]
  FROM [dbo].[TB_Telefonos]
  WHERE [Telefono] LIKE '%' + ISNULL(@Telefono, [Telefono]) + '%'
AND [IdPersona] LIKE '%' + ISNULL(@IdPersona, [IdPersona]) + '%'
go
