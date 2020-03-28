CREATE PROCEDURE [dbo].[SP_Valideur_GetById]
	@utilisateurId int
AS
	SELECT [UtilisateurId],[Status],[Commentaire] FROM [Valideur] WHERE [UtilisateurId] = @utilisateurId
