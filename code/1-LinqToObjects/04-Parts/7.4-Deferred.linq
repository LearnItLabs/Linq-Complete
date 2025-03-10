<Query Kind="Statements" />

// Demonstrating deferred execution with extension methods
var colors = new List<string>() {"Blue", "Crimson", "Brown", "Caramel",
								"Copper","Orange" };

var searchLetter = "B";

// Define a query using Where (not executed yet).
var q = colors.Where(c => c.StartsWith(searchLetter));


// Change the contents of the List<string>
colors.Remove("Blue");
colors.Add("Beige");

q.Dump("Same as the query expression");


