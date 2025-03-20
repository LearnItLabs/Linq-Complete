<Query Kind="Statements">
  <Connection>
    <ID>b8c4dc23-131e-4b0f-8c01-82a9e2f816a6</ID>
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

//      ^  ^

/* View results in rich text (default) or data grids.

Switch between the two using the toolbar buttons above.

Additionally, you can: 
- Click headers to sort data and type in columns for incremental searches 
- Reorder columns with Alt+Click 
- Freeze columns via right-click 
- Select areas of the grid to export to CSV, HTML, or Excel
*/

var q1 = from c in Customers
				where c.City.StartsWith ("S")
				select c;
				
q1.Dump();