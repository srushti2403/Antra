--1. List all cities that have both Employees and Customers.
SELECT DISTINCT e.City
FROM Employees e JOIN Customers c ON e.City = c.City

--2. List all cities that have Customers but no Employee.
--a. use sub-query
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN (SELECT e.City FROM Employees e)

--b. do not use sub-query
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL

--3. List all products and their total order quantities throughout all orders.
SELECT DISTINCT p.ProductName, SUM(od.Quantity) AS TotalQuantity
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName
ORDER BY TotalQuantity DESC

--4. List all Customer Cities and total products ordered by that city.
SELECT c.City, SUM(od.Quantity) AS TotalProducts
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
ORDER BY TotalProducts DESC

--5. List all Customer Cities that have at least two customers.
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2

--6. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2

--7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT c.CustomerID, c.ContactName, c.City AS CustomerCity, o.ShipCity
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity

--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.

--9. List all cities that have never ordered something but we have employees there.
--a. use sub-query
SELECT DISTINCT e.City
FROM Employees e
WHERE e.City NOT IN (
    SELECT DISTINCT o.ShipCity
    FROM Orders o
)

--b. do not use sub-query
SELECT DISTINCT e.City
FROM Employees e LEFT JOIN Orders o ON e.City = o.ShipCity
WHERE o.ShipCity IS NULL

--10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)


--11. How do you remove the duplicates record of a table?
--ANS. 1. Identify duplicates using a SELECT query and then remove them.
--     2. Delete duplicates directly and keeping a single unique record.