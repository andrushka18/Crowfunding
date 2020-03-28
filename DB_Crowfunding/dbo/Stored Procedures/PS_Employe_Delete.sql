CREATE PROCEDURE [dbo].[PS_Employe_Delete]
	@utilisateurId int,
	@NN int
	

AS
	SELECT @utilisateurId, @NN FROM [Employe] WHERE [UtilisateurId] = @utilisateurId AND NumeroNational=@NN

RETURN 0
