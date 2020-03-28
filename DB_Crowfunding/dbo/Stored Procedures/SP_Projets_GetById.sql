CREATE PROCEDURE [dbo].[SP_Projets_GetById]
	@idProjet int
AS
	SELECT IdProjet, Nom, UrlVideo FROM [Projets] WHERE [IdProjet] = @idProjet
