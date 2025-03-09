<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
		   "White", "Black", "Blue" ,"Bronze"};
colors.Dump("Original List");

// Static method sytax.
// var w = Enumerable.Where(colors, c => c.StartsWith("B"));

// Call with extension method syntaxx
var w = colors.Where(c => c.StartsWith("B"));

w.Dump();

// or
// var a = Enumerable.Last(colors);
var a = colors.Last().Dump();

// pipeline
var b = colors.Where(c => c.StartsWith("B")).Last();
