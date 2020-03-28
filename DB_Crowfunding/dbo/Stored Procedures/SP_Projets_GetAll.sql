CREATE PROCEDURE [dbo].[SP_Projets_GetAll]
AS
	SELECT IdProjet, Nom, PlafondFinance, UrlVideo FROM [Projets]
