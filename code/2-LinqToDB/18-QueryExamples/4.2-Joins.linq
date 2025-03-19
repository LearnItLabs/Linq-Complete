<Query Kind="Statements">
  <Connection>
    <ID>b8c4dc23-131e-4b0f-8c01-82a9e2f816a6</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="EF7Driver" PublicKeyToken="469b5aa5a4331a8c">EF7Driver.StaticDriver</Driver>
    <CustomAssemblyPath>D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\DataDepot\DataDepot.dll</CustomAssemblyPath>
    <AppConfigPath>D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\DataDepot\appsettings.json</AppConfigPath>
    <CustomTypeName>NorthwindLib.Models.NorthwindDbContext</CustomTypeName>
    <DriverData>
      <UseDbContextOptions>false</UseDbContextOptions>
    </DriverData>
  </Connection>
</Query>

// The DB joins are defined in the EF mapping
// this simplifies common queries.



	var q2 = from o in OrderDetails
					 where o.Order.CustomerId == "ISLAT"
					 select new {o.Order.Customer.CompanyName, o.Order.OrderDate,
					 o.Product.ProductName, 
					 Employee= o.Order.Employee.FirstName + " " + o.Order.Employee.LastName,
					 o.Quantity};
						
	q2.Take (10).Dump();