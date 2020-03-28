CREATE PROCEDURE [dbo].[SP_Financeur_Unlink]
	@utilisateurId int,
	@idProjet int
AS
	DELETE FROM [Financeur] WHERE [UtilisateurId] = @utilisateurId AND [IdProjet] = @idProjet
