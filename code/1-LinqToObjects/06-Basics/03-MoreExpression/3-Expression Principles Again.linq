<Query Kind="Statements" />

// 3. Takes a sequence, returns a single value.
//    AKA (fold, reduce, aggregate, accumulate, etc.)
//		reduces a list of data to a aggregate value
//    min, max, sum

IEnumerable<string> colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
			 "White", "Black", "Blue" ,"Bronze"};


// this query takes a list of strings and returns a list of integers
// remember to us the extension methods to perform this operation
IEnumerable<int> q1 = from c in colors
												 select c.Length;

q1.Dump();
int count = q1.Min();

count.Dump("Shortest Word" );