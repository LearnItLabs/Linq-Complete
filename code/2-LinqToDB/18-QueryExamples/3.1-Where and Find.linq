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

// Use Find to get an entity with the specified key value
// This is faster if item is cached in the context (DbContext in this example).

// Microsoft Docs: Find is different from using a query:
// A round-trip to the database happens if the entity 
// with the given key is not found in the context.

 Products.Where(p => p.ProductId == 4).Single().Dump();
 Products.Where(p => p.ProductId == 4).Single().Dump();
//Products.Find(4).Dump();
//Products.Find(4).Dump();