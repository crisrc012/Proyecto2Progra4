USE [ClubCampestre]
GO
-- Eliminar - Opción, cambiar a desactivar a nivel de estado
create procedure [dbo].[sp_delete_Customer]
(
	@CustomerID integer
)
as
delete from [dbo].[tblCustomer]
where [CustomerID] = @CustomerID
go
-- Insertar
create procedure [dbo].[sp_insert_Customer]
(
	@CustomerID integer
	,@CustomerName varchar(MAX)
	,@CustomerArea varchar(MAX)
	,@CustomerSubsidiary varchar(MAX)
)
as
IF NOT EXISTS (SELECT [CustomerID]
                  ,[CustomerName]
                  FROM [dbo].[tblCustomer]
                  WHERE [CustomerID] = @CustomerID
                  OR [CustomerName] = @CustomerName)
   BEGIN
       INSERT INTO [dbo].[tblCustomer]
			([CustomerID]
      ,[CustomerName]
      ,[CustomerArea]
      ,[CustomerSubsidiary]
      ,[CreationDate]
      ,[CreatedBy]
      ,[ModificationDate]
      ,[ModificatedBy])
       VALUES (@CustomerID
           ,@CustomerName
		   ,@CustomerArea
		   ,@CustomerSubsidiary
           ,GETDATE()
           ,SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1,15) --Obtiene el usuario actual
           ,NULL
           ,NULL)
   END
   -- return select / escalar
go
-- Filtrar
create procedure [dbo].[sp_search_Customer]
(
	@CustomerName varchar(MAX)
	,@CustomerArea varchar(MAX)
	,@CustomerSubsidiary varchar(MAX)
)
as
SELECT [CustomerID]
      ,[CustomerName]
      ,[CustomerArea]
      ,[CustomerSubsidiary]
  FROM [dbo].[tblCustomer]
  where [CustomerName] LIKE '%' + ISNULL(@CustomerName, [CustomerName]) + '%'
  and [CustomerArea] LIKE '%' + ISNULL(@CustomerArea, [CustomerArea]) + '%'
  and [CustomerSubsidiary] LIKE '%' + ISNULL(@CustomerSubsidiary, [CustomerSubsidiary]) + '%'
go
-- Consultar
create procedure [dbo].[sp_select_Customer]
as
SELECT [CustomerID]
      ,[CustomerName]
      ,[CustomerArea]
      ,[CustomerSubsidiary]
      ,[CreationDate]
      ,[CreatedBy]
      ,[ModificationDate]
      ,[ModificatedBy]
  FROM [dbo].[tblCustomer]
go
-- Update
create procedure [dbo].[sp_update_Customer]
(
	@CustomerID integer
	,@CustomerName varchar(MAX)
	,@CustomerArea varchar(MAX)
	,@CustomerSubsidiary varchar(MAX)
)
as
update [dbo].[tblCustomer]
   set
      [CustomerName] = @CustomerName
	  ,[CustomerArea] = @CustomerArea
      ,[CustomerSubsidiary] = @CustomerSubsidiary
      ,[ModificationDate] = GETDATE()
      ,[ModificatedBy] = SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1,15) --Obtiene el usuario actual
 where [CustomerID] = @CustomerID
 -- return select / escalar
go