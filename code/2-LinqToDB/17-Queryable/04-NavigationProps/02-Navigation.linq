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

var db = new NorthwindDbContext();

// Use navigation properties to drill into sub collections.
// Represented as property on the Model classes.



var q1 = db.Customers.Where(c => c.CompanyName.StartsWith("T")).Where(c => c.Orders.Count >3).Select(c=>c);

 
 q1.Dump();
 
var q2 =  from c in db.Customers
					let orderCount = c.Orders.Count( )
					where orderCount >200
					orderby c.CompanyName
					select new {c.CompanyName, orderCount};
	q2.Dump();