----Select

--Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

--Select * from Customers where City='London'

----case insensitive  --> select=Select=SElEct

--Select * from Products where CategoryID=1 or CategoryID=3

--Select * from Products where CategoryID=1 and UnitPrice>=10

--Select * from Products order by UnitPrice asc -- > ascending

--Select * from Products order by UnitPrice desc -- > descenting

--Select * from Products where CategoryId=1 order by UnitPrice desc

--Select COUNT(*) from Products

--Select COUNT(*) from Products where CategoryID=1

--Select CategoryID, count(*) from Products group by CategoryID

--Select CategoryId,COUNT(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10

--Select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
-- from Products inner join Categories
-- on Products.CategoryId = Categories.CategoryId

--DTO data transformation object

--Select * from Products p inner join [Order Details] od 
-- on p.ProductID=od.ProductID

--Select * from Products p left join [Order Details] od 
-- on p.ProductID=od.ProductID

Select * from Customers c left join Orders o 
 on c.CustomerID=o.CustomerID
 where o.CustomerID is null







