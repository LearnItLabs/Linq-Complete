<Query Kind="Statements">
  <Connection>
    <ID>ed9c21bd-aa27-4ba0-97a6-40816b8ea640</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="EF7Driver" PublicKeyToken="469b5aa5a4331a8c">EF7Driver.StaticDriver</Driver>
    <CustomAssemblyPath>D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\DataDepot\DataDepot.dll</CustomAssemblyPath>
    <AppConfigPath>D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\DataDepot\appsettings.json</AppConfigPath>
    <CustomTypeName>ToursLib.Models.ToursDbContext</CustomTypeName>
    <DriverData>
      <UseDbContextOptions>false</UseDbContextOptions>
    </DriverData>
  </Connection>
  <Output>DataGrids</Output>
</Query>

// use Take/Skip to get less rows without a where clause
// Take: Returns contiguous elements from the start of a sequence.
// Skip: Bypasses elements in a sequence and then returns the remaining elements.
var q1 = from p in Products
				 orderby p.ProductID
				 select new { p.ProductID, p.ProductName, p.UnitPrice };

var count = q1.Count();

count.Dump("Products count");

var pageSize = 5;
var pageCounter = 1;
for (int counter = 0; counter < 3; counter++) {
	pageCounter = pageSize * counter;
	q1.Skip(pageCounter).Take(pageSize).Dump("Next page");
}
