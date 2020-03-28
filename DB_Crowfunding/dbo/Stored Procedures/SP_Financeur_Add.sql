CREATE PROCEDURE [dbo].[SP_Financeur_Add]

	@montant money = 0,
	@prime NVARCHAR(50)

AS
	INSERT INTO [Financeur]([Montant],[Prime]) OUTPUT inserted.IdFinanceur VALUES (@montant, @prime)
