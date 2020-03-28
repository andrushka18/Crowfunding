CREATE PROCEDURE [dbo].[SP_Valideur_Add]

	@status NVARCHAR(50),
	@commentaire NVARCHAR(50)

AS
	INSERT INTO [Valideur]([Status],[Commentaire]) OUTPUT inserted.UtilisateurId VALUES (@status, @commentaire)
