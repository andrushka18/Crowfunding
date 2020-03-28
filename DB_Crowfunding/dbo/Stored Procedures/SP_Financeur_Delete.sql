CREATE PROCEDURE [dbo].[SP_Financeur_Delete]
	@utilisateurId int
AS
	SELECT UtilisateurId, Montant, Prime FROM [Financeur] WHERE [UtilisateurId] = @utilisateurId
