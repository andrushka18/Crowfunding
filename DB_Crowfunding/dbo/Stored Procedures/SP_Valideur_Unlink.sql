CREATE PROCEDURE [dbo].[SP_Valideur_Unlink]
	@utilisateurId int,
	@idProjet int
AS
	DELETE FROM [Valideur] WHERE [UtilisateurId] = @utilisateurId AND [IdProjet] = @idProjet
