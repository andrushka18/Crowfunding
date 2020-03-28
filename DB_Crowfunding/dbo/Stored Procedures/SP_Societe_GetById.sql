CREATE PROCEDURE [dbo].[SP_Societe_GetById]
	@numeroTVA int
AS
	SELECT [Description], [NumeroTVA] FROM [Societe] WHERE [NumeroTVA] = @numeroTVA
