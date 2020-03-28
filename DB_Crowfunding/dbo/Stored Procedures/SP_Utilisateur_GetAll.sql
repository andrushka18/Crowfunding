CREATE PROCEDURE [dbo].[SP_Utilisateur_GetAll]
	
AS
	SELECT [UtilisateurId], [Nom], [Prenom], [NomUtilisateur] FROM [Utilisateur]
