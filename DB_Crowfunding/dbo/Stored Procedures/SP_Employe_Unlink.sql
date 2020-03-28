CREATE PROCEDURE [dbo].[SP_Employe_Unlink]
	@utilisateurId int,
	@idProjet int,
	@numeroTVA varchar(50)
AS
	DELETE FROM [Employe] WHERE [UtilisateurId] = @utilisateurId AND [IdProjet] = @idProjet AND [NumeroTVA]= @numeroTVA
