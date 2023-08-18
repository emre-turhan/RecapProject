-- Drop Cars Table
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Cars')
BEGIN
    DROP TABLE Cars;
END

-- Drop Colors Table
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Colors')
BEGIN
    DROP TABLE Colors;
END

-- Drop Brands Table
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Brands')
BEGIN
    DROP TABLE Brands;
END

CREATE TABLE Brands (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100)
);

-- Create Colors Table
CREATE TABLE Colors (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100)
);

-- Create Cars Table with Foreign Key Constraints
CREATE TABLE Cars (
    Id INT PRIMARY KEY,
    BrandId INT,
    ColorId INT,
    ModelYear INT,
    DailyPrice DECIMAL(10, 2),
    Description NVARCHAR(MAX),
);