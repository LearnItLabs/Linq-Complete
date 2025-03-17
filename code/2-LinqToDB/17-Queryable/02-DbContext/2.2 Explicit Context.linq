<Query Kind="Statements">
  <Connection>
    <ID>f38ceccc-d873-4ebc-b79d-c3ba06d89c93</ID>
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