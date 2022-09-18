--Task 1:
--Display firstname,lastname from person.person whose title is not null.

select * from person.Person

select Person.FirstName,LastName
from Person.Person

--Task 2:
--Display Firstname,lastname from person.person whose firstname and lastname should have
--atleast one 'a';.

select * from person.Person

select Person.FirstName,LastName 
from Person.Person
where FirstName like 'a%' and LastName Like 'a%'

--Task 3:
--Display currencycode,name from Sales.Currency and Sales.CountryRegionCurrency without
--using joins

select * from Sales.Currency
select * from Sales.CountryRegionCurrency

select  CY.CurrencyCode,CY.Name
from  Sales.Currency CY,Sales.CountryRegionCurrency CRC

--Task 4:
--Copy humanresources.department table to the new table named as 'HR.Dept';

select * from HumanResources.Department

SET IDENTITY_INSERT HR.Dept ON

insert into HR.Dept
( sno,DepartmentID, Name,GroupName, ModifiedData)
select sno,DepartmentID, Name,GroupName, ModifiedData 
from HumanResources.Department
SET IDENTITY_INSERT HR.Dept OFF
--select * from HR.Dept

--Task 5:
--Create a table with column named 'SNo' and make that column as identity.insert 20 rows using
--insert into statement(table should contain 5 columns)

CREATE TABLE [Student].[FirstStd](
	[StudentID] [smallint] IDENTITY(1,1) NOT NULL,
	[Name]  varchar(100) NOT NULL,
	[Address] varchar(100) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_FirstStd_StudentID] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


insert into [Student].[FirstStd] Name,Address,ModifiedData,createDate
values ('Divya','Coimbatore',getdate(),getdate())
insert into [Student].[FirstStd] Name,Address,ModifiedData,createDate
values ('Deepa','Chennai',getdate(),getdate())
insert into [Student].[FirstStd] Name,Address,ModifiedData,createDate
values ('Arthi','Coimbatore',getdate(),getdate())
insert into [Student].[FirstStd] Name,Address,ModifiedData,createDate
values ('Gopika','Palani',getdate(),getdate())
insert into [Student].[FirstStd] Name,Address,ModifiedData,createDate
values ('Manikam','Bangalore',getdate(),getdate())

select * from FirstStd

--Task 6:
--Perform inner join operation to display businessentityid,addresstypeid from
--humanresources.department and Person.BusinessEntityAddress
select * from Person.Person
select * from Person.BusinessEntityAddress

select BEA.BusinessEntityID,BEA.AddressTypeID
from Person.Person p
join Person.BusinessEntityAddress BEA on BEA.BusinessEntityID = P.BusinessEntityID

--Task 7:
--Display distinct values of column named 'Group name' from humanresources.department
 select * from HumanResources.Department

 select distinct groupName
 from humanresources.department

--Task 8:
--Display documentnode,StandardCost,sum of ListPrice & StandardCost from
--Production.ProductCostHistory and Production.Product
select top 1* from Production.ProductCostHistory
select  top 1* from Production.Product
select  top 1* from [Production].[ProductDocument]

select documentnode,P.StandardCost, (ListPrice + PCH.StandardCost) Price
from Production.Product P
join Production.ProductCostHistory  PCH on PCH.ProductID = P.ProductID
JOIN [Production].[ProductDocument] D on P.ProductID=d.ProductID

--Task 9:
--Use Datediff() fumction to find 'Years on role' using Startdate and enddate from
--HumanResources.EmployeeDepartmentHistory

select * from HumanResources.EmployeeDepartmentHistory

select  DATEDIFF(year,startDate,isnull(enddate,getdate())) yearsonrole
from HumanResources.EmployeeDepartmentHistory 

--Task 10:
--Filter the data from Sales.SalesPersonQuotaHistory whose sum of '5000 and SalesQuota' is
--greater than 100000. Arrange in ascending order with respect to the sum of salesquota and 5000

select * From Sales.SalesPersonQuotaHistory

select 5000 

from Sales.SalesPersonQuotaHistory 

--Task 11:
--find the maximum taxrate as Max_taxrate from sales.salestaxrate

select * from sales.salestaxrate

select max (TaxRate )
from sales.SalesTaxRate

--Task 12:
--Perform Join Operation and display DepartmentID,BusinessentityId,ShiftId,BirthDate.Find Age
--and display.(use getdate() function).
--Note: Use
--HumanResources.Employee,HumanResources.Department,HumanResources.EmployeeDepartment
--entHistory.

select * from HumanResources.Department
select * from HumanResources.Employee
select * from HumanResources.EmployeeDepartmentHistory



select EDH.DepartmentID,EDH.BusinessentityId,EDH.ShiftID,E.BirthDate,DATEDIFF(year,BirthDate,getdate()) Age
from HumanResources.Employee E
join  HumanResources.EmployeeDepartmentHistory EDH on E.BusinessEntityID  = EDH.BusinessEntityID
join HumanResources.Department D on D.DepartmentID = EDH.DepartmentID


--Task 13:
--Create view named 'Name_age' for Task-12
create view HumanResource.Name_age 
as 
select EDH.DepartmentID,EDH.BusinessentityId,EDH.ShiftID,E.BirthDate,DATEDIFF(year,BirthDate,getdate()) Age
from HumanResources.Employee E
join  HumanResources.EmployeeDepartmentHistory EDH on E.BusinessEntityID  = EDH.BusinessEntityID
join HumanResources.Department D on D.DepartmentID = EDH.DepartmentID

--Task 14:
--Find the total number of rows in the tables starting with schema name 'humanresources'.Display
--result as No_of_rows_hr



--Task 15:
--Display maximum rate for each department
select * from HumanResources.Department
select * from [HumanResources].[EmployeeDepartmentHistory]
select * from [HumanResources].[EmployeePayHistory]

select d.DepartmentID,d.Name, MAX(Rate) MaximumRate
from HumanResources.EmployeeDepartmentHistory EDH 
join HumanResources.Department D on D.DepartmentID = EDH.DepartmentID
join HumanResources.EmployeePayHistory EPH on EPH.BusinessEntityID = EDH.BusinessEntityID
Group by d.DepartmentID,d.Name 

--Task 16:
--perform Left join between person.person and person.BusinessEntityAddress and display
--FirstName,MiddleName,Title,AddressTypeID,businessentityID.Don't display the names whose
--title is null

select * from Person.Person
select * from Person.BusinessEntityAddress

select P.FirstName,P.MiddleName,P.Title,BEA.AddressTypeID,BEA.BusinessEntityID
from Person.Person p
 Left join Person.BusinessEntityAddress BEA on BEA.BusinessEntityID = P.BusinessEntityID
 where  P.FirstName  is not null

 --Task 17:
--Display ProductID,LocationID,Shelf from Production.ProductInventory whose ProductID should
--be between 300-350,LocationID should be 50 or Shelf = 'E'

select * from Production.ProductInventory 

select PN.ProductID,PN.LocationID,PN.Shelf
from Production.ProductInventory PN
WHERE (ProductID >= 300 and ProductID <= 350) AND (LocationID = 50 or Shelf = 'E')

--Task 18:
--Display LocationID,Shelf,Name by joining Production.ProductInventory and
--Production.Location

select * from Production.ProductInventory
select * from Production.Location

select ProIn.LocationID,ProIn.Shelf, L.Name
from Production.ProductInventory ProIn
Join Production.Location L on L.LocationID = ProIn.LocationID

--Task 19:
--DisplayAddressID,AddressLine1,AddressLine2,StateProvinceID,StateProvinceCode,CountryRegionCode 
--from Person.StateProvince and Person.Address

select * from Person.StateProvince
select * from Person.Address


select Ad.AddressID,Ad.AddressLine1,Ad.AddressLine2,AD.StateProvinceID,sp.StateProvinceCode,sp.CountryRegionCode
from Person.StateProvince SP
join Person.Address Ad on Ad.StateProvinceID = SP.StateProvinceID

--Task 20:
--Display currency code,sum of subtotal and TaxAmt as total using
--Sales.SalesOrderHeader,Sales.SalesTerritory and Sales.CountryRegionCurrency

Select * from Sales.SalesTerritory
Select * from Sales.CountryRegionCurrency
select * from Sales.SalesOrderHeader

select CRC.CurrencyCode, (SubTotal + TaxAmt) Total 
from Sales.SalesTerritory ST 
join Sales.CountryRegionCurrency CRC on CRC.CountryRegionCode = ST.CountryRegionCode
join Sales.SalesOrderHeader SOH on SOH.TerritoryID = ST.TerritoryID

