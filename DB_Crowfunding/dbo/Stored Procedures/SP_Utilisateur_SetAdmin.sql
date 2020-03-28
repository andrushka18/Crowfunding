CREATE PROCEDURE [dbo].[SP_Utilisateur_SetAdmin]
	@utilisateurId int,
	@idDroit int
AS
	UPDATE [Droit] SET [NomDroit] = 'Administrateur' WHERE [IdDroit] = @idDroit 
