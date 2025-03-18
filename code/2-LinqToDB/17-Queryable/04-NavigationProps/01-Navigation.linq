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


// Use navigation properties to drill into sub collections.
// Represented as DbSet<T> properties.
var db = new NorthwindDbContext();
db.Regions.Dump();
var regionRow = db.Regions.ElementAt(1);
regionRow.Dump("First Region");

var ts = regionRow.Territories;
ts.Dump("Region Territories");

// var emp = ts.First().Employees.First( );
var territoryRow = ts.ElementAt(6);
territoryRow.Dump("The territory");


territoryRow.Employees.Dump();

var emp = territoryRow.Employees.First();

emp.Dump("The Employee");

emp.FirstName.Dump ("The employee name");	



