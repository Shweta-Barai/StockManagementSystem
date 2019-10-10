CREATE DATABASE StockManagementSystem

USE StockManagementSystem

CREATE TABLE Category
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Code VARCHAR(10),
	Name VARCHAR(20)
)

SELECT * FROM Category