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
  <Output>DataGrids</Output>
</Query>

// Where clause filters the number of rows returned 
// Select clause (aka projection) filters the number of columns returned

	Customers.Count().Dump("# rows in Customers");
	var q1 = from c in Customers
					where c.City.StartsWith ("S")
					select c;
					
	// check the generated SQL, this gets all columns
	q1.Dump ();

	var q2 = from c in Customers
					 where c.City.StartsWith ("S")
					 select new {c.CompanyName, c.Address, c.City};
	q2.Dump();
	q2.ToQueryString().Dump();