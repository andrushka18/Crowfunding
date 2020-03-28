CREATE PROCEDURE [dbo].[SP_Valideur_GetAll]
AS
	SELECT [UtilisateurId],[Status],[Commentaire] FROM [Valideur]
