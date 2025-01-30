<Query Kind="Statements" />

// The 'Any' can return true as soon as it's found a matching element

// 'Count' must iterate through all the results;
 
var numbers = new List<int>{ 1, 3, 5, 11, 23, 3, 9 };
 
 if (numbers.Count() >0)
	{
		// this is slower
	}


	if (numbers.Any ())
	{
		// this is faster
	}
