--Select
create procedure [dbo].[sp_select_TB_Persona]
as
select [IdPersona] ,[Nombre] ,[Direccion] ,[IdRol] from [dbo].[TB_Persona]
go
--Insert
create procedure [dbo].[sp_insert_TB_Persona]
(
	@IdPersona varchar (20) ,@Nombre varchar (50) ,@Direccion varchar (150) ,@IdRol tinyint
)
as
IF NOT EXISTS (SELECT [IdPersona] ,[Nombre] ,[Direccion] ,[IdRol]
                  FROM [dbo].[TB_Persona]
                  WHERE [IdPersona] = @IdPersona
AND [Nombre] = @Nombre
AND [Direccion] = @Direccion
AND [IdRol] = @IdRol)
   BEGIN
       INSERT INTO [dbo].[TB_Persona]
			([IdPersona] ,[Nombre] ,[Direccion] ,[IdRol])
       VALUES (@IdPersona ,@Nombre ,@Direccion ,@IdRol)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdPersona])
  FROM [dbo].[TB_Persona]
go
--Update
create procedure [dbo].[sp_update_TB_Persona]
(
	@IdPersona varchar (20) ,@Nombre varchar (50) ,@Direccion varchar (150) ,@IdRol tinyint
)
as
update [dbo].[TB_Persona]
   set
      [IdPersona] = @IdPersona
,[Nombre] = @Nombre
,[Direccion] = @Direccion
,[IdRol] = @IdRol
 where [IdPersona] = @IdPersona
go
--Delete
create procedure [dbo].[sp_delete_TB_Persona]
(
	@IdPersona varchar (20)
)
as
delete from [dbo].[TB_Persona]
where [IdPersona] = @IdPersona
go
-- Filtrar
create procedure [dbo].[sp_search_TB_Persona]
(
	@IdPersona varchar (20) ,@Nombre varchar (50) ,@Direccion varchar (150) ,@IdRol tinyint
)
as
IF @IdRol = 0
BEGIN
	SET @IdRol = null
END
SELECT [IdPersona] ,[Nombre] ,[Direccion] ,[IdRol]
  FROM [dbo].[TB_Persona]
  WHERE [IdPersona] LIKE '%' + ISNULL(@IdPersona, [IdPersona]) + '%'
AND [Nombre] LIKE '%' + ISNULL(@Nombre, [Nombre]) + '%'
AND [Direccion] LIKE '%' + ISNULL(@Direccion, [Direccion]) + '%'
AND [IdRol] = ISNULL(@IdRol, [IdRol])
go
