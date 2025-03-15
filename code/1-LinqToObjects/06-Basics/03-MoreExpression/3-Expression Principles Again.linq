<Query Kind="Statements" />

// 3. Sequence to Single Value:
//		Takes a sequence, returns a single value.
//    AKA (fold, reduce, aggregate, accumulate, etc.)
//		reduces a list of data to a aggregate value
//    min, max, sum

IEnumerable<string> colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgundy","Purple",
			 "White", "Black", "Blue" ,"Bronze"};


// This query takes a list of strings and returns a list of integers.
// Cannot use aggregate method in Query expression syntax. 
// Use the extension methods to perform these operations.
IEnumerable<int> q1 = from c in colors
											select c.Length;

q1.Dump();
int count = q1.Min(); // Get the shortest word.

count.Dump("Shortest Word" );