<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgundy","Purple",
			 "White", "Black", "Blue" ,"Bronze", "Bronze", "Yellow", "Blue"};


// write pipeline example
// Where returns IEnumerable<T>

var pipe1 = colors.Where(c => c.Length > 5);

// OrderBy returns IOrderedEnumerable<T>
var pipe2 = pipe1.OrderBy(p => p);

pipe2.Dump("ordered and filtered");

// Distinct returns IEnumerable<T>
var pipe3 = pipe2.Distinct();

pipe3.Dump("Remove duplicates");

// or like this

var q = colors.Where(c => c.Length > 5).OrderBy(c => c).Distinct();

q.Dump("Single line pipeline");


