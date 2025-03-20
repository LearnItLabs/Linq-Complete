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
</Query>

// SelectMany flattens a one-many relationship
// or saying it another way , it can ungroup nested sequences


Regions.Dump();
var q1 = from r in Regions
				 select r.Territories;
q1.Dump("4 hashset collections in result");

// how to get the third territory
var thirdTerritory = q1.ToList()[2].FirstOrDefault();

var q2 = Regions.SelectMany(r => r.Territories);

q2.Select(t => new { t.TerritoryId, t.TerritoryDescription }).Dump("Flattened to a single Queryable");

// get third territory

q2.ElementAt(2).Dump();
