<Query Kind="Program">
  <NuGetReference>System.Data.SqlClient</NuGetReference>
  <NuGetReference>System.Data.SQLite</NuGetReference>
  <Namespace>System.Data.SQLite</Namespace>
  <Namespace>System.Numerics</Namespace>
</Query>

// LINQPad provides an easy way to get data context for a database
// this example bypasses the LINQPad system and uses basic ADO.NET
// Note:  since this is .NET core
// add System.Data.Common and Microsoft.Data.SqlClient NuGet package for SQL database.

// This example uses a Sqlite database, add Microsoft.Data.Sqlite NuGet package.
void Main()
{

	string cnString = @"data source='D:\repos\LearnItLabs\Linq-Complete\code\Data\Sqlite\northwind.sqlite'";
	DataSet ds;
	using (var conn = new SQLiteConnection(cnString))
	{
		conn.Open();
		 ds = GetDataSet(conn);

		ds.Dump();
		conn.Close();

	}
}


public DataSet GetDataSet(SQLiteConnection conn)
{
	var dataSet = new DataSet("NorthwindDemo");
	var shippersAdapter = new SQLiteDataAdapter("Select * From Shippers", conn);
	shippersAdapter.Fill(dataSet, "Shippers");
	var productsAdapter = new SQLiteDataAdapter("Select [ProductName],[UnitPrice], [UnitsInStock]From Products ", conn);
	productsAdapter.Fill(dataSet, "Products");

	return dataSet;

}
