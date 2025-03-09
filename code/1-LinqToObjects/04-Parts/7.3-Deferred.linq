<Query Kind="Statements" />

// Demonstrating deferred execution with extension methods
var colors = new List<string>() {"Blue", "Crimson", "Brown", "Caramel",
								"Copper","Orange" };

// Define a query using Where (not executed yet).
var q = colors.Where(c => c.StartsWith("C"));

// Run the query

q.Dump("first run");

// Add a new color to the list
colors.Add ("Coral");

q.Dump("second run");


// modify the query by adding ordering

var q2 = q.OrderBy(c => c);

q2.Dump("third run");