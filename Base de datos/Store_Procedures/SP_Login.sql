create procedure [dbo].[sp_login]
(
	@IdPersona varchar (20), @Contrasena varchar (50)
)
as
IF EXISTS (SELECT TBU.IdPersona
  FROM [ClubCampestre].[dbo].[TB_Usuarios] TBU
  WHERE TBU.Contrasena = @Contrasena
  AND TBU.IdPersona = @IdPersona)
   BEGIN
		SELECT [IdUsuario], [IdRol]
		FROM [ClubCampestre].[dbo].[TB_Usuarios] TBU
		JOIN [ClubCampestre].[dbo].[TB_Persona] TBP
		ON TBU.IdPersona = TBP.IdPersona
		WHERE TBU.[IdPersona] = @IdPersona
   END
go