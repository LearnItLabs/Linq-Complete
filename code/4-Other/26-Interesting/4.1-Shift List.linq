<Query Kind="Statements" />

string[] words = { "apple", "banana", "cherry", "durian",
														"eggplant", "fig", "grape", "honey", "ice", "jam" };
														
	
	var offset  = 3;
	
	words.Skip(offset).Concat(words.Take(offset)).Dump();
	