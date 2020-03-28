CREATE PROCEDURE [dbo].[SP_Employe_Link]
	@utilisateurId int,
	@idProjet int,
	@numeroTVA varchar(50)
AS
	INSERT INTO [Employe] ([UtilisateurId],[IdProjet],[NumeroTVA]) VALUES (@utilisateurId,@idProjet,@numeroTVA)
