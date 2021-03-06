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
BEGIN
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
END
GO
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
	@IdCliente smallint
)
as
BEGIN
	delete from [dbo].[TB_Beneficiarios]
	where [IdCliente] = @IdCliente
END
GO
-- Filtrar
create procedure [dbo].[sp_search_TB_Beneficiarios]
(
	@IdBeneficiario smallint ,@IdCliente smallint ,@IdPersona varchar (20) ,@IdEstado char (1)
)
as
BEGIN
	IF @IdBeneficiario = -32768
	BEGIN
		SET @IdBeneficiario = null
	END
	IF @IdCliente = -32768
	BEGIN
		SET @IdCliente = null
	END
	IF @IdPersona = ''
	BEGIN
		SET @IdPersona = null
	END
	IF @IdEstado = ' '
	BEGIN
		SET @IdEstado = null
	END

	SELECT [IdBeneficiario] ,[IdCliente] ,B.[IdPersona] ,[IdEstado], P.[Nombre]
	  FROM [dbo].[TB_Beneficiarios] B
	  INNER JOIN [dbo].[TB_Persona] P
	  ON P.IdPersona = B.IdPersona
	  WHERE [IdBeneficiario] = ISNULL(@IdBeneficiario, [IdBeneficiario])
	AND [IdCliente] = ISNULL(@IdCliente, [IdCliente])
	AND B.[IdPersona] LIKE '%' + ISNULL(@IdPersona, B.[IdPersona]) + '%'
	AND [IdEstado] LIKE '%' + ISNULL(@IdEstado, [IdEstado]) + '%'
END
GO