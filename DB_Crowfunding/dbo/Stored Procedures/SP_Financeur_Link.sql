CREATE PROCEDURE [dbo].[SP_Financeur_Link]
	@utilisateurId int,
	@idProjet int
AS
	INSERT INTO [Financeur] ([UtilisateurId],[IdProjet]) VALUES (@utilisateurId,@idProjet)
