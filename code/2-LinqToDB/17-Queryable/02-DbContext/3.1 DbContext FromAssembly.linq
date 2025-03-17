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

	// The normal syntax for instantiating the DbContext
	var context = new ToursDbContext();
	//
	context.Testimonials.Dump();
	
	// or use the properties direct in LINQPad
	
	// LINQPad direct access, no need for the instance variable.
	TravelTips.Dump();
	var type = context.GetType();
	type.FullName.Dump("Context Type");
	type.BaseType.FullName.Dump("Base Type");