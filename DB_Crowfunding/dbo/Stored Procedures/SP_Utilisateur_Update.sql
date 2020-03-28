CREATE PROCEDURE [dbo].[SP_Utilisateur_Update]
	@utilisateurId INT,
	@nom NVARCHAR(50),
	@prenom NVARCHAR(50)
AS
	UPDATE [Utilisateur]
	SET [Nom] = @nom,
		[Prenom] = @prenom
	WHERE [UtilisateurId] = @utilisateurId
