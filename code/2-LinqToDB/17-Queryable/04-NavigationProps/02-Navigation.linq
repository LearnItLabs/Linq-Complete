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

var db = new NorthwindDbContext();

// Use navigation properties to drill into sub collections.
// Represented as DbSet<T> properties.



 db.Regions.Dump();
 var regionRow = db.Regions.First();
 regionRow.Dump("First Regions");
 
 var ts = regionRow.Territories;
 ts.Dump("Navigate to Territories");
 
 var emp = ts.First().Employees.First( );
 
emp.LastName.Dump();
 
 
 
