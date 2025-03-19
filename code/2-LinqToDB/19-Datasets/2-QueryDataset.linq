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

// This example uses a Sqlite database, so add Microsoft.Data.Sqlite NuGet package.
// use code from the util-source file
#load "2-LinqToDB\19-Datasets\Util-Source"
void Main()
{
	string cnString = GetSqliteConnString();

	using (var conn = new SQLiteConnection(cnString))
	{
		conn.Open();

		var ds = GetDataSet(conn);

		//ds.Dump();
		// LINQ to Datasets is based on LINQ to Objects.
		// Convert the DataTable to an IEnumerable<DataRow> with .AsEnumerable
		var shippers = ds.Tables["Shippers"].AsEnumerable();
		shippers.Dump();
		shippers.First().Dump();
		conn.Close();

	}
}


