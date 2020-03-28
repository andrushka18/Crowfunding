CREATE PROCEDURE [dbo].[SP_Utilisateur_GetById]
	@utilisateurId INT
AS
	SELECT [UtilisateurId], [Nom], [Prenom], [NomUtilisateur], [IdDroit] FROM  [Utilisateur] JOIN [Droit] ON [Utilisateur].[UtilisateurId] = [Droit].[IdDroit] WHERE [UtilisateurId] = @utilisateurId
