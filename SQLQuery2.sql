use TestDb
go

CREATE OR ALTER PROCEDURE GetProducts as
begin 
select p.productName, c.categoryName
from [dbo].[Product] p left join [dbo].[ProductCategory] pc on p.productId = pc.productId
					   left join [dbo].[Category] c on c.categoryId = pc.categoryId
end

GetProducts