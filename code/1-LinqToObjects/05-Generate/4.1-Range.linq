<Query Kind="Statements" />

// Range:
// Generates a sequence of integral numbers within a specified range.

var numbers = Enumerable.Range(start: 1000, count: 30);

numbers.Dump();

numbers = Enumerable.Range(start: -50, count: 6);

numbers.Dump();

// Filter the sequence to include only odd numbers (e % 2 == 1)
var odds = Enumerable.Range(start: 1, count: 30).Where(e => e % 2 == 1);
odds.Dump();

// double value, use a transform
 IEnumerable<double> doubles = odds.Select(n => n * 0.5);
 
 doubles.Dump("Transformed to double.");

