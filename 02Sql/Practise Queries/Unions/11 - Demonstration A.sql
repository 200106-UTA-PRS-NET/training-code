-- Demonstration A

-- Step 1: Open a new query window to the TSQL database
USE TSQL;
GO

-- Step 2: Using UNION ALL
-- Select this query and execute it to show the use of
-- UNION ALL to return all rows from both tables
-- including duplicates
SELECT country, region, city FROM HR.Employees --9
UNION ALL -- 100 rows
SELECT country, region, city FROM Sales.Customers;--91

-- Step 3: Using UNION
-- Select this query and execute it to show the use of
-- UNION to return all rows from both tables
-- excluding duplicates
SELECT country, region, city FROM HR.Employees 
UNION --77
SELECT country, region, city FROM Sales.Customers; 

