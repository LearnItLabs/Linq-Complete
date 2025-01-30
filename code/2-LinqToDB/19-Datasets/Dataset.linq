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

	using (var conn = new SQLiteConnection(cnString))
	{
		conn.Open();
		var ds  =  GetDataSet (conn);
		
		ds.Dump();
		conn.Close();
	}
}


public DataSet GetDataSet(SQLiteConnection conn)
{
	
	 // A DataSet is an in-memory representation of data that provides a consistent relational programming model,
	 // independent of the data source. It is a collection of DataTable objects, which represent individual tables
	 // within the DataSet. Each DataTable contains rows and columns similar to a database table. 
	 // The DataAdapter acts as a bridge between the DataSet and the data source, facilitating the retrieval and saving of data.
	 // It uses commands to fill the DataSet with data from the data source and update the 
	 // data source with changes made in the DataSet.
	 
	var dataSet = new DataSet("NorthwindDemo");
	var shippersAdapter= new SQLiteDataAdapter("Select * From Shippers", conn);
	shippersAdapter.Fill(dataSet, "Shippers");
	
	var productsAdapter = new SQLiteDataAdapter("Select [ProductName],[UnitPrice], [UnitsInStock]From Products ", conn);
	productsAdapter.Fill(dataSet, "Products");
	
	return dataSet;

}
