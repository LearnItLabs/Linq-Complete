<Query Kind="Statements" />


// It is possible to use multiple sequences in a query.
// This code demonstrates how to use multiple sequences 
// to create a Cartesian product.Here's a summary of what the code does:


var numList = new List<int> {  5, 10, 15, 20, 25, 30 };

int[] numArray = new[] {2,4,6,8};

var q = from fives in numList
				from evens in numArray
				select new {fives, evens, product=fives*evens};
				
				
q.Dump();

