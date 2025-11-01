--14. List all Products that has been sold at least once in last 27 years.
SELECT p.ProductID, p.ProductName
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID
WHERE o.OrderDate >= DATEADD(YEAR, -27, GETDATE())

--15. List top 5 locations (Zip Code) where the products sold most.
SELECT TOP 5 o.ShipPostalCode AS ZipCode, SUM(od.Quantity) AS QuantSold
FROM [Order Details] od JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY o.ShipPostalCode
ORDER BY QuantSold DESC

--16. List top 5 locations (Zip Code) where the products sold most in last 27 years.
SELECT TOP 5 o.ShipPostalCode AS ZipCode, SUM(od.Quantity) AS QuantSold
FROM [Order Details] od JOIN Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate >= DATEADD(YEAR, -27, GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY QuantSold DESC

--17. List all city names and number of customers in that city.
SELECT City, COUNT(CustomerID) AS NumberOfCustomers
FROM Customers
GROUP BY City

--18. List city names which have more than 2 customers, and number of customers in that city
SELECT City, COUNT(CustomerID) AS NumberOfCustomers
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2

--19. List the names of customers who placed orders after 1/1/98 with order date.
SELECT c.ContactName, o.OrderDate
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1998-01-01'

--20. List the names of all customers with most recent order dates.
SELECT c.ContactName, o.OrderDate
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate = (SELECT MAX(OrderDate) FROM Orders)

--21. Display the names of all customers  along with the  count of products they bought
SELECT c.ContactName, COUNT(od.ProductID) AS ProductsBought
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.ContactName

--22. Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CustomerID, COUNT(od.ProductID) AS ProductsBought
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING COUNT(od.ProductID) > 100

--23. List all of the possible ways that suppliers can ship their products. 
SELECT s.CompanyName as [Supplier Company Name], sh.CompanyName AS [Shipper Company Name]
FROM Suppliers s CROSS JOIN Shippers sh
ORDER BY s.CompanyName, sh.CompanyName

--24. Display the products order each day. Show Order date and Product Name.
SELECT CAST(o.OrderDate AS date) AS OrderDate, p.ProductName
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON od.ProductID = p.ProductID
ORDER BY OrderDate, p.ProductName

--25. Displays pairs of employees who have the same job title.
SELECT e1.FirstName + ' ' + e1.LastName AS Employee1, e2.FirstName + ' ' + e2.LastName AS Employee2, e1.Title AS JobTitle
FROM Employees e1 JOIN Employees e2 ON e1.Title = e2.Title AND e1.EmployeeID < e2.EmployeeID
ORDER BY e1.Title, Employee1, Employee2

--26. Display all the Managers who have more than 2 employees reporting to them.
SELECT m.EmployeeID AS ManagerID, m.FirstName + ' ' + m.LastName AS ManageName, COUNT(e.EmployeeID) AS NumberOFEmployees
FROM Employees e JOIN Employees m ON e.ReportsTo = m.EmployeeID
GROUP BY m.EmployeeID, m.FirstName, m.LastName
HAVING COUNT(e.EmployeeID) > 2
ORDER BY NumberOFEmployees DESC

--27. Display the customers and suppliers by city.
SELECT City, CompanyName AS Name, ContactName, 'Customer' AS Type
FROM Customers
UNION ALL
SELECT City, CompanyName AS Name, ContactName, 'Supplier' AS Type
FROM Suppliers
ORDER BY City, Type, Name