CREATE PROCEDURE [dbo].[SP_Financeur_Update]
	@utilisateurId INT,
	@montant money, 
	@prime NVARCHAR(50)
AS
	UPDATE [Financeur] SET [Montant] = @montant , [Prime]= @prime WHERE [UtilisateurId] = @utilisateurId

