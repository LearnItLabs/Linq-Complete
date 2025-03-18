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

// Use the SQL window
var context = new NorthwindDbContext();

context.Categories.ToQueryString().Dump(); 

var q1 = from s in Shippers	
					select s;
					
q1.ToQueryString().Dump();					


// run the queries to see the real SQL sent to database
q1.Dump();