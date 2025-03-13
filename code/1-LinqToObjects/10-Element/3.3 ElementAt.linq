<Query Kind="Statements" />

// ElementAt: Returns the element at a specified index in a sequence.

// ElementAtOrDefault: Returns the element at a specified index in a sequence or a default value if the index is out of range.


var numbers = new List<int> { 0, 5, 10, 15, 20, 25, 30 };

var q = from number in numbers
				where number >20
				select number;
				
q.Dump("what does this return?");
// q[1].Dump(); //Error: No indexer available


q.Dump("indexed array");

q.ElementAt(1).Dump("Use on IEnumerable<T>");
