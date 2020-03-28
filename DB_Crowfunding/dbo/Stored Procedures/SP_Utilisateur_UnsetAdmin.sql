CREATE PROCEDURE [dbo].[SP_Utilisateur_UnsetAdmin]
	@utilisateurId int,
	@idDroit int
AS
		UPDATE [Droit] SET [NomDroit] = 'Utilisateur' WHERE [IdDroit] = @idDroit 
