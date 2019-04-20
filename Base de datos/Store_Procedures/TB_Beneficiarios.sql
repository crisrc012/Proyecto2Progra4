--Select
create procedure [dbo].[sp_select_TB_Beneficiarios]
as
select [IdBeneficiario] ,[IdCliente] ,[IdPersona] ,[IdEstado] from [dbo].[TB_Beneficiarios]
go
--Insert
create procedure [dbo].[sp_insert_TB_Beneficiarios]
(
	@IdBeneficiario smallint ,@IdCliente smallint ,@IdPersona varchar (20) ,@IdEstado char (1)
)
as
IF NOT EXISTS (SELECT [IdBeneficiario] ,[IdCliente] ,[IdPersona] ,[IdEstado]
                  FROM [dbo].[TB_Beneficiarios]
                  WHERE [IdBeneficiario] = @IdBeneficiario
AND [IdCliente] = @IdCliente
AND [IdPersona] = @IdPersona
AND [IdEstado] = @IdEstado)
   BEGIN
       INSERT INTO [dbo].[TB_Beneficiarios]
			([IdCliente] ,[IdPersona] ,[IdEstado])
       VALUES (@IdCliente ,@IdPersona ,@IdEstado)
   END
   -- Devuelve la ultima llave generada
  SELECT MAX ([IdBeneficiario])
  FROM [dbo].[TB_Beneficiarios]
go
--Update
create procedure [dbo].[sp_update_TB_Beneficiarios]
(
	@IdBeneficiario smallint ,@IdCliente smallint ,@IdPersona varchar (20) ,@IdEstado char (1)
)
as
update [dbo].[TB_Beneficiarios]
   set
      [IdCliente] = @IdCliente
,[IdPersona] = @IdPersona
,[IdEstado] = @IdEstado
 where [IdBeneficiario] = @IdBeneficiario
go
--Delete
create procedure [dbo].[sp_delete_TB_Beneficiarios]
(
	@IdBeneficiario smallint
)
as
delete from [dbo].[TB_Beneficiarios]
where [IdBeneficiario] = @IdBeneficiario
go
-- Filtrar
create procedure [dbo].[sp_search_TB_Beneficiarios]
(
	@IdBeneficiario smallint ,@IdCliente smallint ,@IdPersona varchar (20) ,@IdEstado char (1)
)
as
SELECT [IdBeneficiario] ,[IdCliente] ,[IdPersona] ,[IdEstado]
  FROM [dbo].[TB_Beneficiarios]
  WHERE [IdBeneficiario] LIKE '%' + ISNULL(@IdBeneficiario, [IdBeneficiario]) + '%'
AND [IdCliente] LIKE '%' + ISNULL(@IdCliente, [IdCliente]) + '%'
AND [IdPersona] LIKE '%' + ISNULL(@IdPersona, [IdPersona]) + '%'
AND [IdEstado] LIKE '%' + ISNULL(@IdEstado, [IdEstado]) + '%'
go
