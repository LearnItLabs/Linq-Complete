<Query Kind="Statements" />

	var numbers = new List<int> { 2, 4, 6, 8, 100, 200, 300, 1, 3, 5, 7, 400 };
	// start with 
	// from varname in sequence

	var qs1 = from n in numbers
			 			select n;
						
	var qs2 =  numbers.Select(n =>n );
	var qs3 = Enumerable.Select(numbers,n => n);

	qs1.Dump("Simple pass through query");


