CREATE PROCEDURE [dbo].[SP_Palier_Delete]
	@idPalier int
AS
	SELECT IdPalier, Montant, Prime FROM [Palier] WHERE [IdPalier] = @idPalier
