--Select Yorum satırı
--Ansii
Select ContactName Adi ,CompanyName  SirketAdi,City Sehir From Customers

Select * From Customers where City='berlin'

---case insentitive

Select * from Products where CategoryID = 1 or CategoryID=3
Select * from Products where CategoryID = 1 and UnitPrice>=10
select * from Products order by ProductName
select * from Products order by CategoryID
select * from Products order by CategoryID,ProductName
select * from Products where categoryId= 1 order by UnitPrice desc              --asscending

select count(*) adet from Products 

select * from products group by CategoryId--yanlış ikullanım

select categoryId ,count(*) from products where UnitPrice>20  group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName,Products.UnitPrice,Categories.CategoryName
from  Products inner join Categories
on Products.CategoryID=Categories.CategoryID where UnitPrice>10

--dto data tranformation object

select * from Products p inner join  [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID


select * from Customers  c left join Orders o 
on  c.CustomerID = o.CustomerID
where o.CustomerID is null



 
