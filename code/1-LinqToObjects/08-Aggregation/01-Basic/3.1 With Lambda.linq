<Query Kind="Statements" />

	var numbers = new List<int> { 50, 4, 10, 3, 90, 8, -60, 7, 20, 5 };

	var countOf = numbers.Count();
	// count take a optional predicate lambda
	var anotherCountOf = numbers.Count(n => n > 20);

	countOf.Dump("Count");
	anotherCountOf.Dump("Count with predicate");