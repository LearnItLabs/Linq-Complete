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

// DbSet implements IQueryable
// DbSet represents the EF model for a database table

// The Regions table in EF ORM is mapped to the DbContext.Regions property
// public virtual DbSet<Region> Regions { get; set; }
// a row in the Regions table is mapped to the Region class

 
 var allRegions = context.Regions;
 allRegions.Dump();
 var regionRow = allRegions.First();
 regionRow.Dump();
 
