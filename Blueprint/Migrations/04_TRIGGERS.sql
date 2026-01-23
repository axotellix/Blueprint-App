-- TRIGGER: Auto update Client
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_UpdateClients')
    DROP TRIGGER trg_UpdateClients;
GO

CREATE TRIGGER trg_UpdateClients
ON Orders
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- add > user to Clients (if no user found)
    INSERT INTO Clients (user_id, first_order_date, total_orders, total_spent)
    SELECT 
        i.user_id,
        MIN(i.order_date),
        1,
        i.total_amount
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1 FROM Clients c 
        WHERE c.user_id = i.user_id
    )
    GROUP BY i.user_id, i.total_amount;
    
    -- update > existing clients` statistics
    UPDATE c
    SET 
        total_orders = c.total_orders + 1,
        total_spent = c.total_spent + i.total_amount
    FROM Clients c
    INNER JOIN inserted i ON c.user_id = i.user_id
    WHERE EXISTS (
        SELECT 1 FROM Clients 
        WHERE user_id = i.user_id
    );
END;
GO

-- TRIGGER: set product edit time
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_UpdateProductTimestamp')
    DROP TRIGGER trg_UpdateProductTimestamp;
GO

CREATE TRIGGER trg_UpdateProductTimestamp
ON Products
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE Products
    SET last_updated = GETDATE()
    WHERE product_id IN (SELECT product_id FROM inserted);
END;
GO