CREATE PROCEDURE [dbo].[SP_Role_Utilisateur_Unlink]
	@utilisateurId int,
	@idDroit int
AS
	DELETE FROM [Role_Utilisateur] WHERE [UtilisateurId] = @utilisateurId AND [IdDroit] = @idDroit 
