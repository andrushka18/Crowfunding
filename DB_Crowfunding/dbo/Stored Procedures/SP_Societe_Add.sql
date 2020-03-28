CREATE PROCEDURE [dbo].[SP_Societe_Add]

	@numeroTVA INT = 0,
	@description NVARCHAR(50)

AS
	INSERT INTO [Societe]([NumeroTVA],[Description]) OUTPUT inserted.NumeroTVA VALUES (@numeroTVA, @description)
