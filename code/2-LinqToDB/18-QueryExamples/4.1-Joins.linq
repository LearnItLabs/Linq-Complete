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
</Query>

// The DB joins are defined in the EF mapping
// In the entity classes they are represented as Navigation properties.
// Navigation properties provide a way to navigate an association between two entity types 
// They allow you to navigate and manage relationships in both directions

// this simplifies common LINQ queries.



	var q2 = from o in OrderDetails
						where o.Order.CustomerID =="ISLAT"
						select o;
					
q2.Dump();