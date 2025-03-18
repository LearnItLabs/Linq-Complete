<Query Kind="Statements">
  <Connection>
    <ID>8f05af3e-7fc0-4d94-9ed4-6c648ddee6cf</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <AttachFileName>D:\repos\LearnItLabs\Linq-Complete\code\Data\Sqlite\Tours.sqlite</AttachFileName>
    <DisplayName>Tours</DisplayName>
    <DriverData>
      <EncryptSqlTraffic>True</EncryptSqlTraffic>
      <PreserveNumeric1>True</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.Sqlite</EFProvider>
    </DriverData>
  </Connection>
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



