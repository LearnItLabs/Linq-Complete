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

Testimonials.Dump(); // no context needed
TypedDataContext linqpadContext = this;

linqpadContext.Dump();

linqpadContext.TravelTips.Dump();


var type = linqpadContext.GetType();
type.FullName.Dump("Context Type");
type.BaseType.FullName.Dump("Base Type");