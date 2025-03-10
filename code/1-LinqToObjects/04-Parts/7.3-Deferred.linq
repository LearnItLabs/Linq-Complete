<Query Kind="Statements" />

// Demonstrating deferred execution with extension methods
var colors = new List<string>() {"Blue", "Crimson", "Brown", "Caramel",
																"Copper","Orange" };

var searchLetter = "B";

// Define a potential query (not executed yet).
var q = from c in colors
				where c.StartsWith(searchLetter)
				select c;

// change the contents of the List<string>
	colors.Remove("Blue");
	colors.Add ("Beige");

// Run the query, what do you see?
q.Dump("What do you see?");

// Since the query ran after list was updated...