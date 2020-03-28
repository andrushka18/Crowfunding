CREATE PROCEDURE [dbo].[SP_Utilisateur_ChangePassword]
	@utilisateurId INT,
	@motDePasse NVARCHAR(50)
AS
	UPDATE Utilisateur
		SET [Password] = [dbo].SF_HashPassword(@motDePasse)
	WHERE UtilisateurId = @utilisateurId
