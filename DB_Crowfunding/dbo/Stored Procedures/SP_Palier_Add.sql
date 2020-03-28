CREATE PROCEDURE [dbo].[SP_Palier_Add]

	@montant money = 0,
	@prime NVARCHAR(50)

AS
	INSERT INTO [Palier]([Montant],[Prime]) OUTPUT inserted.IdPalier VALUES (@montant, @prime)
