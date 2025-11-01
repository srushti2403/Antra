--1. How many products can you find in the Production.Product table?
SELECT COUNT(ProductID) AS NumberOfProducts
FROM Production.Product

--2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
SELECT COUNT(*) AS ProductsInSubcategory
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

--3. How many Products reside in each SubCategory?
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID
ORDER BY ProductSubcategoryID

--4. How many products that do not have a product subcategory.
SELECT COUNT(*) AS NoSubcategory
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

--5. Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT SUM(Quantity) AS SumOfProducts
FROM Production.ProductInventory

--6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.
SELECT p.ProductID, SUM(p.Quantity) AS TheSum
FROM Production.ProductInventory p
WHERE p.LocationID = 40
GROUP BY p.ProductID
HAVING SUM(p.Quantity) < 100

--7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
SELECT p.Shelf, p.ProductID, SUM(p.Quantity) AS TheSum
FROM Production.ProductInventory p
WHERE p.LocationID = 40 AND p.Shelf IS NOT NULL
GROUP BY p.Shelf, p.ProductID
HAVING SUM(p.Quantity) < 100

--8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
SELECT AVG(Quantity) 
FROM Production.ProductInventory
WHERE LocationID = 10

--9. Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

--10. Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID, Shelf

--11. List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.
SELECT p.Color, p.Class, COUNT(p.ProductID) AS TheCount, AVG(p.ListPrice) AS AvgPrice
FROM Production.Product p
WHERE p.Color IS NOT NULL AND p.Class IS NOT NULL
GROUP BY p.Color, p.Class
ORDER BY p.Color, p.Class

--12. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode

--13. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany', 'Canada')