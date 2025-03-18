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

// use Take/Skip to get less rows without a where clause
// Take: Returns contiguous elements from the start of a sequence.
// Skip: Bypasses elements in a sequence and then returns the remaining elements.
	var q1 = from p in Products
					 orderby p.ProductID
					 select new {p.ProductID, p.ProductName, p.UnitPrice};
					 
	var count = q1.Count();

	count.Dump("Products count");

	var pageSize = 5;
	q1.Take(pageSize).Dump("First page");
	q1.Skip(pageSize).Take (pageSize).Dump("Next page");