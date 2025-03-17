<Query Kind="Statements">
  <Connection>
    <ID>78feeb8f-8587-4984-b154-cd46924cf378</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
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
</Query>

Testimonials.Dump(); // no context needed
TypedDataContext linqpadContext = this;

linqpadContext.Dump();

linqpadContext.TravelTips.Dump();


var type = linqpadContext.GetType();
type.FullName.Dump("Context Type");
type.BaseType.FullName.Dump("Base Type");