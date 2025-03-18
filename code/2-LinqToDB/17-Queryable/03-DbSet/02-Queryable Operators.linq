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

// DbSet implements IQueryable
// DbSet represents the EF model for a database table

// These are the Queryable operators that we can use on our DbSets

var queryableMethods =
		 from m in typeof(Queryable).GetMethods(BindingFlags.Public | BindingFlags.Static)
		 where m.IsPublic
		 orderby m.Name
		 select m.Name ;

queryableMethods.Distinct().Dump();


