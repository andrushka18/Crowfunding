CREATE PROCEDURE [dbo].[SP_Palier_GetAll]
AS
	SELECT IdPalier,IdProjet, Montant, Prime FROM [Palier]Join [Projets] ON [Palier].[IdPalier] = [Projets].[IdProjet]
