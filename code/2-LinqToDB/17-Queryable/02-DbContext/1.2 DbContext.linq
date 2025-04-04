<Query Kind="Statements">
  <Connection>
    <ID>26d579d0-e134-466a-aa95-6b5d4d17e2d7</ID>
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
</Query>

	// What methods and properties are available on the DbContext.
	var context = new ToursDbContext();
	
	//
	var type = context.GetType();

 var methods = type.GetMethods();
 var props = type.GetProperties();
 
 var q = from m in methods
 				 where m.Name.Contains("_") == false
 				 orderby m.Name
				 select m.Name;
q.Distinct().Dump();

var q2 = from p in props
				 orderby p.Name
				 select new { p.Name, Type = p.PropertyType};
q2.Distinct().Dump();

