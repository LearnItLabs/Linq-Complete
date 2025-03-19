<Query Kind="Statements">
  <Connection>
    <ID>5937cd49-6dbe-4750-96bb-da714e4b6d30</ID>
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


	var q1 = from p in Products
					 select new {p.ProductName, p.UnitPrice};
	q1.Dump();

/* 
//The following query expressions worked in EF 6, but not newer versions
Entity Framework translates the grouping and aggregation into SQL
that the database can execute. Without a projection (like new { Key, Products }),
the query cannot be mapped to a valid SQL operation.
*/
var q2 = from p in Products
						 group p by p.ProductName.Substring(0,1) into g
						 select g;			 
	//q2.Dump();

	var q3 = from p in Products
					 group new { p.ProductName, p.UnitPrice } by p.ProductName.Substring(0,1) into g
					 select new {
						 Key = g.Key,
						 Products = g.ToList()};


	q3.Dump();