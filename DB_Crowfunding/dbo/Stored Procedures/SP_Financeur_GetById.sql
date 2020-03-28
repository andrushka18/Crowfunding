CREATE PROCEDURE [dbo].[SP_Financeur_GetById]
	@utilisateurId int
AS
	SELECT UtilisateurId, IdProjet, Montant, Prime FROM [Financeur] WHERE [UtilisateurId] = @utilisateurId


