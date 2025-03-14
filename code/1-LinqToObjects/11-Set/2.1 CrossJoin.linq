<Query Kind="Statements" />


// It is possible to use multiple sequences in a query.
// This code demonstrates how to use multiple sequences 
// to create a Cartesian product.Here's a summary of what the code does:


var fives = new List<int> { 5, 10, 15, 20, 25, 30 };

int[] evens = new[] { 2, 4, 6, 8 };

var q = from f in fives
				from e in evens
				where f > 15
				&& e > 3
				select new { f, e, product = f * e };


q.Dump();

