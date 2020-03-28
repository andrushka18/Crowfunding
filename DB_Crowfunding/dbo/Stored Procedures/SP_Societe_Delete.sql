CREATE PROCEDURE [dbo].[SP_Societe_Delete]
	@numeroTVA int
AS
	SELECT [Description], [NumeroTVA] FROM [Societe] WHERE [NumeroTVA] = @numeroTVA
