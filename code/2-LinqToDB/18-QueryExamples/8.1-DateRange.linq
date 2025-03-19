<Query Kind="Statements">
  <Connection>
    <ID>5937cd49-6dbe-4750-96bb-da714e4b6d30</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="EF7Driver" PublicKeyToken="469b5aa5a4331a8c">EF7Driver.StaticDriver</Driver>
    <CustomAssemblyPath>D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\DataDepot\DataDepot.dll</CustomAssemblyPath>
    <AppConfigPath>D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\DataDepot\appsettings.json</AppConfigPath>
    <CustomTypeName>NorthwindLib.Models.NorthwindDbContext</CustomTypeName>
    <DriverData>
      <UseDbContextOptions>false</UseDbContextOptions>
    </DriverData>
  </Connection>
</Query>

// get orders in date range

	TimeSpan thirtyDays = TimeSpan.FromDays(30);

	// get an order
	var q1 = from o in Orders
			 where o.OrderId == 10250
			select new {o.OrderId, o.OrderDate, o.ShipName};

	q1.Dump();

	var originalDate = q1.First().OrderDate;
	var futureDate = originalDate + thirtyDays;
	var q2= from o in Orders
			where o.OrderDate > originalDate && o.OrderDate < futureDate
			select new {o.OrderId, o.OrderDate, o.ShipName};

	q2.Dump();