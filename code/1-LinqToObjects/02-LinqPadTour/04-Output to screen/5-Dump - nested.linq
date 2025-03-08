<Query Kind="Statements" />

// Create a nested list of integers

Dictionary<string, List<int>> nestedDictionary = new Dictionary<string, List<int>>();

// Add string keys and their corresponding nested lists
nestedDictionary["First"] = new List<int> { 10, 20, 30 };
nestedDictionary["Second"] = new List<int> { 4, 5, 6 };
nestedDictionary["Third"] = new List<int> { 7, 8, 9};

nestedDictionary.Dump();