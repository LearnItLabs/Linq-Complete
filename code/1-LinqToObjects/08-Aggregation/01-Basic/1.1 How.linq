<Query Kind="Statements" />

// An aggregate operation produces a single value
// From the input sequence 
// example (a,b,c,d,e)
// perform an operation with each sucessive pair

// result = operation (a, b)
// result = operation (result, b)
// result = operation (result, c)
// result = operation (result, d)
// result = operation (result, e)


	var numbers = new List<int> { 50, 4, 10, 3, 90, 8, -60, 7, 20, 5 };

	var total = numbers.Sum();

	total.Dump("Sum");
