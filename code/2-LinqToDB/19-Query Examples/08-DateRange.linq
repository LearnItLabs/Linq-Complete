<Query Kind="Statements">
  <Connection>
    <ID>e84f6018-5946-4d14-a8b1-86541c3b32ea</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <AttachFile>true</AttachFile>
    <AttachFileName>D:\repos\LearnItLabs\Linq-Complete\code\Data\SqlServer\Northwind.V15.MDF</AttachFileName>
    <DisplayName>Northwind</DisplayName>
    <DriverData>
      <EncryptSqlTraffic>True</EncryptSqlTraffic>
      <PreserveNumeric1>True</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
  <Reference>C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// get orders in date range

TimeSpan thirtyDays = TimeSpan.FromDays(30);

// get an order
var q1 = from o in Orders
		 where o.OrderID == 10250
		select new {o.OrderID, o.OrderDate, o.ShipName};

q1.Take(1).Dump();

var originalDate = q1.First().OrderDate;
var futureDate = originalDate + thirtyDays;
var q2= from o in Orders
		where o.OrderDate > originalDate & o.OrderDate < futureDate
		select new {o.OrderID, o.OrderDate, o.ShipName};

q2.Dump();