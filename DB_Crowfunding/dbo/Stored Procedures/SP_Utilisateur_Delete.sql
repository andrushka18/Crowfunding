CREATE PROCEDURE [dbo].[SP_Utilisateur_Delete]
	@utilisateurId INT
AS
	DELETE FROM [Utilisateur]
	WHERE [UtilisateurId] = @utilisateurId
