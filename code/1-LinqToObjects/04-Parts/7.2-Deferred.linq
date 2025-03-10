<Query Kind="Statements" />

var colors = new List<string>() {"Blue", "Crimson", "Brown", "Caramel",
																"Copper","Orange" };

var searchLetter = "B";
// Define a potential query (not executed yet).
var q = from c in colors
		where c.StartsWith(searchLetter)
		select c;

// Change the search letter
searchLetter = "C";

// Run the query, what do you see?
q.Dump("what do you see?");

// Since the query ran after the search string was changed...