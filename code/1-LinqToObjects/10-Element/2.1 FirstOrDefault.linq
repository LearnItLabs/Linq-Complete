<Query Kind="Statements" />

// The First and Last methods throw an exception if source contains no elements. 


// use FirstOrDefault, LastOrDefault

var numbers = new List<int> { 50, 4, 10, 3, 90, 8, -60, 7, 20, 5 };

var emptyNumbers = new List<int>();


numbers.First().Dump();
// throws an exceptions
emptyNumbers.First().Dump();

