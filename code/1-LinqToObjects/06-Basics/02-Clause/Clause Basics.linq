<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
			 "White", "Black", "Blue" ,"Bronze"};

// The Query expression syntax is a substitute for calling the 
// the query operator extension methods directly.

// These expressions use a set of special keywords, 
// also known as clauses, to create readable and concise queries

// ✅ from – Specifies the data source and introduces the range variable.
// ✅ in – Indicates the source collection being queried.
// ✅ select / group – Every query expression must end with either 
//    select (to shape the output) or group(to group results).

// Optional keywords
// [where, orderby, join, let, by, into, ascending, descending]

var q1 = from c in colors
				 select c;
var q2 = colors.Select(c => c ); // the same query with a method call

var q3 = from color in colors
				 group color by color[0];
 
q1.Dump();

q3.Dump();