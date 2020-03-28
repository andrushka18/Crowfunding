CREATE PROCEDURE [dbo].[SP_Palier_Unlink]
	@idPalier int,
	@idProjet int
AS
	DELETE FROM [Palier]  WHERE [IdPalier] = @idPalier 
