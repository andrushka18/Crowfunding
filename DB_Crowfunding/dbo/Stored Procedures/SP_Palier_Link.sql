CREATE PROCEDURE [dbo].[SP_Palier_Link]
	@idPalier int,
	@idProjet int
AS
	INSERT INTO [Palier] ([IdPalier]) VALUES (@idPalier)
