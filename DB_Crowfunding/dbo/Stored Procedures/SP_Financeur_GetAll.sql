CREATE PROCEDURE [dbo].[SP_Financeur_GetAll]
AS
	SELECT UtilisateurId, IdProjet, Montant, Prime FROM [Financeur]
