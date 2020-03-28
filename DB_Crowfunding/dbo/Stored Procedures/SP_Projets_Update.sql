CREATE PROCEDURE [dbo].[SP_Projets_Update]
	@idProjet INT,
	@plafondFinance money,
	@nom NVARCHAR(50)
AS
	UPDATE [Projets] SET [Nom] = @nom,[PlafondFinance]= @plafondFinance WHERE [IdProjet] = @idProjet
