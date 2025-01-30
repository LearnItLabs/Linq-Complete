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
  <Reference>C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

var numbers = new List<Int32> { 3, 5, 7, 9, 11 };
var q1 = from n in numbers
				where n < 20
				select n;

q1.Dump("Linq to Objects query");
// The where clause uses the Enumerable.Where
// Implmented via an anonymous method
q1.ToString().Dump("Using the Enumerable Where");

// LINQ to EF queries types with IQueryable
// LINQ to EF creates an expression tree
// Uses the Queryable.Where

var q2 = from p in Products
				 where p.UnitPrice > 100
				 select new { p.ProductName, p.UnitPrice };

q2.Dump("Linq to EF, query");
q2.GetType().GetInterfaces().Dump("DbQuery interfaces");

q2.ToString().Dump("Using the  Where");
q2.Expression.Dump();