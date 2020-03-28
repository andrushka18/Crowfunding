CREATE PROCEDURE [dbo].[SP_Utilisateur_Check]
	@nomUtilisateur NVARCHAR(50),
	@motDePasse NVARCHAR(50),
	@utilisateurId INT OUTPUT
AS
	SET @utilisateurId = 0;
	IF EXISTS (SELECT UtilisateurId FROM Utilisateur WHERE NomUtilisateur = @nomUtilisateur AND [Password] = dbo.SF_HashPassword(@motDePasse))
		SELECT @utilisateurId = UtilisateurId FROM Utilisateur WHERE NomUtilisateur = @nomUtilisateur
RETURN 0
