USE Test

SELECT p.[Name] AS product, c.[Name] AS category
FROM Products p
LEFT JOIN ProductAndCatrgory pac ON p.Id=pac.ProductsId 
LEFT JOIN Category c ON c.Id=pac.CategoryId 
ORDER BY product, category