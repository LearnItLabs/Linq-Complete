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
  <Output>DataGrids</Output>
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