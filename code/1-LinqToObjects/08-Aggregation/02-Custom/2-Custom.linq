<Query Kind="Statements" />

// define a function to call from custom aggregator
// Aggregate works like fold in Haskell/ML/F#.
// create a string from a List

var foods = new List<string> { "apple", "banana", "cherry", "durian", "eggplant",
															  "fig", "grape", "honey", "jalapeno", "kale" };


	var result = foods.Aggregate((a, b) => $"{b}, {a}" );

	result.Dump();