CREATE PROCEDURE [dbo].[SP_Valideur_Delete]
	@utilisateurId int
AS
	SELECT [UtilisateurId],[Status],[Commentaire] FROM [Valideur] WHERE [UtilisateurId] = @utilisateurid
