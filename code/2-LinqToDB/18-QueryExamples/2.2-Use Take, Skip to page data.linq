<Query Kind="Statements">
  <Connection>
    <ID>e84f6018-5946-4d14-a8b1-86541c3b32ea</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
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
  <Output>DataGrids</Output>
</Query>

// use Take/Skip to get less rows without a where clause
// Take: Returns contiguous elements from the start of a sequence.
// Skip: Bypasses elements in a sequence and then returns the remaining elements.
var q1 = from p in Products
				 orderby p.ProductID
				 select new { p.ProductID, p.ProductName, p.UnitPrice };

var count = q1.Count();

count.Dump("Products count");

var pageSize = 5;
var pageCounter = 1;
for (int counter = 0; counter < 3; counter++) {
	pageCounter = pageSize * counter;
	q1.Skip(pageCounter).Take(pageSize).Dump("Next page");
}
