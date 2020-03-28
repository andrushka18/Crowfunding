CREATE PROCEDURE [dbo].[SP_Employe_Add]
	@NN int,
	@datedengagement date
AS
	INSERT INTO [Employe]([NumeroNational],[DateDEngagement]) OUTPUT inserted.UtilisateurId VALUES (@NN, @datedengagement)

