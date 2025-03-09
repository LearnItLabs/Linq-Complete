<Query Kind="Statements" />

// The execution of a query is distinct from the creation of the query. 
// Creating a query does not automatically retrieve data; executing the query is required to access the data.

// Query creation and execution are separate processes.  
// Defining a query does not automatically retrieve data;  
// the query must be executed to access the results.

var numbers = new List<int> { 5, 4, 3, 2, 1, 9, 8, 7, 6 };

// Define a potential query (not executed yet).
var q = from n in numbers
				orderby n
				select n;

// Execute the query and store results as an array.
var numsAsArray = q.ToArray();

// Execute the query again and store results as a list.
var asList = q.ToList();

// Traditional way to execute the query and iterate through results.
foreach (var item in q) {
	Console.WriteLine(item);
}