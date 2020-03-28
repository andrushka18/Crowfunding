CREATE PROCEDURE [dbo].[SP_Valideur_Link]
	@utilisateurId int,
	@idProjet int
AS
	INSERT INTO [Valideur] ([UtilisateurId],[IdProjet]) VALUES (@utilisateurId,@idProjet)
