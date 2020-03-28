CREATE PROCEDURE [dbo].[PS_Employe_GetAll]
	
AS
	SELECT UtilisateurId, NumeroNational,DateDEngagement, IdProjet, NumeroTVA FROM [Employe]
