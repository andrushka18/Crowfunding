CREATE PROCEDURE [dbo].[SP_Projets_Add]
	@nom NVARCHAR(50),
	@plafondFinance money = 0,
	@numeroCompte NVARCHAR(50),
	@urlVideo NVARCHAR(50)

AS
	INSERT INTO [Projets]([Nom],[PlafondFinance],[NumeroCompte],[UrlVideo]) OUTPUT inserted.IdProjet VALUES (@nom, @plafondFinance, @numeroCompte, @urlVideo)
