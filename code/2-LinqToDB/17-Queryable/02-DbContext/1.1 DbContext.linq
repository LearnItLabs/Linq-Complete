<Query Kind="Statements">
  <Connection>
    <ID>ed9c21bd-aa27-4ba0-97a6-40816b8ea640</ID>
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
  <Reference>C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// DbContext is the central point for interacting 
// with the database using Entity Framework.

// 1. Database Connection Management: It represents a session with the database
//    and is responsible for opening and closing the database connection.

// 2. Change Tracking: It keeps track of changes made to entities so that it knows
//    what SQL commands to generate for inserts, updates, and deletes.

// 3. Query Execution: It is used to execute LINQ queries against the database.

// 4. Transactions: When SaveChanges is called, it wraps all changes in a transaction
//    to ensure that all operations either succeed or fail together, 
//    maintaining data integrity.

 // We don't need to use options, because of the 
 // modification made to the DB context constructors.
	var context = new ToursDbContext();
	
	//
	//
	var type = context.GetType();
	type.FullName.Dump("DbContext Type");
	type.BaseType.FullName.Dump("Base Type");