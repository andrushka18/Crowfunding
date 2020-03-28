CREATE FUNCTION [dbo].[SF_HashPassword]
(
	@motDePasse NVARCHAR(50)
)
RETURNS VARBINARY(32)
AS
BEGIN
	DECLARE @cashCashe NVARCHAR(MAX)
	SET @cashCashe = 'Dru' + @motDePasse + 'shka'
	RETURN HASHBYTES(N'SHA2_256',@cashCashe)
END
