USE BlueprintDB;
GO

-- TABLE: Users
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
BEGIN
    CREATE TABLE Users (
        user_id         INT IDENTITY(1,1)   PRIMARY KEY,
        name            NVARCHAR(50)        NOT NULL,
        surname         NVARCHAR(50)        NOT NULL,
        email           NVARCHAR(100)       UNIQUE NOT NULL,
        password_hash   NVARCHAR(255)       NOT NULL,
        avatar          NVARCHAR(500)       NULL,
        user_type       NVARCHAR(20)        NOT NULL CHECK (user_type IN ('admin', 'client')),
        register_date   DATETIME            DEFAULT GETDATE(),
        is_active       BIT                 DEFAULT 1
    );
    PRINT '[01] Created Table: Users';
END
GO

-- TABLE: Products
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Products')
BEGIN
    CREATE TABLE Products (
        product_id      INT IDENTITY(1,1)   PRIMARY KEY,
        product_name    NVARCHAR(200)       NOT NULL,
        description     NVARCHAR(MAX),
        price           DECIMAL(10,2)       NOT NULL CHECK (price >= 0),
        img_path        NVARCHAR(500),
        category        NVARCHAR(100),
        stock_quantity  INT DEFAULT 0       CHECK (stock_quantity >= 0),
        is_available    BIT DEFAULT 1
    );
    PRINT '[02] Created Table: Products';
END
GO

-- TABLE: Orders
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Orders')
BEGIN
    CREATE TABLE Orders (
        order_id                 INT IDENTITY(1,1)   PRIMARY KEY,
        user_id                  INT                 NOT NULL,
        product_id               INT                 NOT NULL,
        order_date               DATETIME            DEFAULT GETDATE(),
        total_amount             INT                 NOT NULL,
        status                   NVARCHAR(50)        DEFAULT 'Working',
        FOREIGN KEY (user_id)    REFERENCES Users(user_id) ON DELETE CASCADE,
        FOREIGN KEY (product_id) REFERENCES Products(product_id)
    );
    PRINT '[03] Created Table: Orders';
END
GO

-- -- TABLE: Clients (filled by trigger)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Clients')
BEGIN
    CREATE TABLE Clients (
        client_id           INT IDENTITY(1,1)   PRIMARY KEY,
        user_id             INT                 UNIQUE NOT NULL,
        first_order_date    DATETIME,
        total_orders        INT                 DEFAULT 0,
        total_spent         INT                 DEFAULT 0,
        FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE
    );
    PRINT '[04] Created Table: Clients';
END
GO