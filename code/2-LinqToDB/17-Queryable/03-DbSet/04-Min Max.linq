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

// These are the Queryable operators that we can use on our DbSets

var context = new NorthwindDbContext();

var q = from p in Products
				where p.UnitPrice > 20
				select p;
				
				
q.Dump("All products less than $20.00");

var minPrice = q.Min(p => p.UnitPrice);
minPrice.Dump("Lowest price of items over $20");
var maxStock = q.Max(p => p.UnitsInStock);

maxStock.Dump("Max Stock count");
