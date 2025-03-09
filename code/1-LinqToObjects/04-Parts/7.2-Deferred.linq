<Query Kind="Statements" />

var colors = new List<string>() {"Blue", "Crimson", "Brown", "Caramel",
																"Copper","Orange" };



var searchLetter = "";
// Define a potential query (not executed yet).
var q = from c in colors
		where c.StartsWith(searchLetter)
		select c;

// Change the search letter
searchLetter = "C";

// Run the query, what do you see?
q.Dump("what do you see?");

// Add a new color to the list
colors.Add("Coral");

// run the query again, what do you see?
q.Dump("second run");