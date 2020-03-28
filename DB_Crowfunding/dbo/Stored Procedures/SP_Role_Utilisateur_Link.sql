CREATE PROCEDURE [dbo].[SP_Role_Utilisateur_Link]
	@utilisateurId int,
	@idDroit int
	
AS
	INSERT INTO [Role_Utilisateur] ([UtilisateurId],[IdDroit]) VALUES (@utilisateurId,@idDroit)
