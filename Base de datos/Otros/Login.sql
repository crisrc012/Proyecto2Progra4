USE [master]
GO
IF NOT EXISTS 
    (SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'LoginName')
BEGIN
    CREATE LOGIN [LoginName] WITH PASSWORD = N'password'
	CREATE LOGIN [servicio] WITH PASSWORD=N'Servicio123', DEFAULT_DATABASE=[ClubCampestre], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
END
GO
USE [ClubCampestre]
GO
CREATE USER [servicio] FOR LOGIN [servicio]
GO
USE [ClubCampestre]
GO
ALTER USER [servicio] WITH DEFAULT_SCHEMA=[dbo]
GO
USE [ClubCampestre]
GO
ALTER ROLE [db_owner] ADD MEMBER [servicio]
GO
