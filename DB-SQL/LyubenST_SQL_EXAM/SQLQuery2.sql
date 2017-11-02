
SELECT TOP 5 p.ProductName, s.CompanyName AS [Supplier company name] 
FROM Products p 
JOIN Suppliers s ON p.SupplierID = s.SupplierID
ORDER BY ProductName ASC;