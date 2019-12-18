CREATE PROCEDURE dbo.ProductInsertCommand
(
	@definition xml,
	@name nvarchar(MAX)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [products] ([definition], [name]) VALUES (@definition, @name)


