CREATE PROCEDURE [dbo].[SP_Societe_GetAll]
AS
	SELECT [NumeroTVA], [Description] FROM [Societe]
