CREATE PROCEDURE [dbo].[SP_Projets_GetByNumeroCompte]
	@numeroCompte NVARCHAR(50)
AS
	SELECT IdProjet, Nom, NumeroCompte FROM [Projets] WHERE [NumeroCompte] = @numeroCompte
