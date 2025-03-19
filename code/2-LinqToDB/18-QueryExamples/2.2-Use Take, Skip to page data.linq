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
  <Output>DataGrids</Output>
</Query>

// use Take/Skip to get less rows without a where clause
// Take: Returns contiguous elements from the start of a sequence.
// Skip: Bypasses elements in a sequence and then returns the remaining elements.
var q1 = from p in Products
				 orderby p.ProductName	
				 where p.UnitPrice < 30
				 select new { p.ProductId, p.ProductName, p.UnitPrice };

var count = q1.Count();

count.Dump("Products count");

var pageSize = 5;
var pageCounter = 1;
for (int counter = 0; counter < 3; counter++) {
	pageCounter = pageSize * counter;
	q1.Skip(pageCounter).Take(pageSize).Dump("Next page");
}
