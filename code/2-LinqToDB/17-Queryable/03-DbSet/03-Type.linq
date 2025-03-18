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

var context = new NorthwindDbContext();

/*

InternalDbSet<T> is a class that inherits from 
Microsoft.EntityFrameworkCore.DbSet<T> in Entity Framework Core. 
It is essentially a concrete implementation used internally 
by EF Core to provide the behavior of DbSet.
*/


var allRegions = context.Regions;
allRegions.Dump();

var myType = context.Regions.GetType();
myType.BaseType.Namespace.Dump();
myType.BaseType.Name.Dump();