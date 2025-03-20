<Query Kind="Program">
  <NuGetReference>System.Data.SqlClient</NuGetReference>
  <NuGetReference>System.Data.SQLite</NuGetReference>
  <Namespace>System.Data.SQLite</Namespace>
  <Namespace>System.Numerics</Namespace>
</Query>

/* LINQPad provides an easy way to get data context for a database
this example bypasses the LINQPad system and uses basic ADO.NET
 Note:  since this is .NET core
 add System.Data.Common and Microsoft.Data.SqlClient NuGet package for SQL database.

 This example uses a Sqlite database, add Microsoft.Data.Sqlite NuGet package.
 use code from the util-source file
 
 Field<T> : This is the most important property. 
					 	It allows us to access a specific column value 
					 	in a strongly-typed way (e.g., Field<int>("ColumnName") for an integer column). 						It's safer and avoids runtime type conversion issues.
 Item (Indexer): We can use this to access column values 
 								by name or index (e.g., row["ColumnName"] or row[0]). 
								However, it's not strongly-typed like Field<T>()
	Table: Refers back to the parent DataTable, 
				 allowing access metadata or related rows if needed.
*/

#load "2-LinqToDB\19-Datasets\Util-Source"
void Main()
{

	string cnString = GetSqliteConnString();

	using (var conn = new SQLiteConnection(cnString))
	{
		conn.Open();

		var ds = GetDataSet(conn);

		var products = ds.Tables["Products"].AsEnumerable();
		var q = from p in products
						where p.Field<decimal>("UnitPrice") > 19
						orderby p.Field<decimal>("UnitPrice")
						select new
						{
							ProductName = p.Field<string>("ProductName"),
							Price = p.Field<decimal>("UnitPrice")
						}
						;


		q.Dump();

		conn.Close();

	}
}

