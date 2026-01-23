-- FUNCTION: Get Products total amount
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'FN' AND name = 'fn_GetTotalProductsCount')
    DROP FUNCTION fn_GetTotalProductsCount;
GO

CREATE FUNCTION fn_GetTotalProductsCount()
RETURNS INT
AS
BEGIN
    DECLARE @TotalCount INT;
    
    SELECT @TotalCount = COUNT(DISTINCT product_id)
    FROM Products
    WHERE is_available = 1;
    
    RETURN ISNULL(@TotalCount, 0);
END;
GO