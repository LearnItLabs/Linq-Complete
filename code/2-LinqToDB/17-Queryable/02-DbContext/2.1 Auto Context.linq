<Query Kind="Statements">
  <Connection>
    <ID>78feeb8f-8587-4984-b154-cd46924cf378</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <AttachFile>true</AttachFile>
    <AttachFileName>D:\repos\LearnItLabs\Linq-Complete\code\Data\SqlServer\Tours.V15.mdf</AttachFileName>
    <DisplayName>Tours</DisplayName>
    <DriverData>
      <EncryptSqlTraffic>True</EncryptSqlTraffic>
      <PreserveNumeric1>True</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
  <Reference>C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// LINQPad has several database connection drivers.

//1. Choose [Build data context automatically]
//   to have a DbContext created by LINQPad for your database connection.

// 2. Choose [Use a typed data context from your own assembly]
//    when you have a .NET .DLL that includes an EF Core data context.

// For the Tours database
// This is an example of the AutoContext


// We don't have to use the explicit DbContext instance.

	Testimonials.Dump(); // no context needed



