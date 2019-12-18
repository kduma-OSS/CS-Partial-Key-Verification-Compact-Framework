CREATE PROCEDURE dbo.ProductSelectCommand
AS
	SET NOCOUNT ON;
SELECT     definition, name, id
FROM         products


