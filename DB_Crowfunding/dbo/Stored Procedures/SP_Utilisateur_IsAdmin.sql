CREATE PROCEDURE [dbo].[SP_Utilisateur_IsAdmin]
	@utilisateurId INT,
	@idDroit int,
	@isAdmin BIT OUTPUT
AS
	SET @isAdmin = 0
	SELECT @isAdmin = IIF([NomDroit] = 'Administrateur', 1, 0) FROM  [Utilisateur] JOIN [Droit] ON [Utilisateur].[UtilisateurId] = [Droit].[IdDroit] WHERE UtilisateurId = @utilisateurId AND IdDroit = @idDroit 
