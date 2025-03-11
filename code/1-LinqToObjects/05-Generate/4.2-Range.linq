<Query Kind="Statements" />

// Range:
// Generates a sequence of integral numbers within a specified range.


// Filter the sequence to include only odd numbers (e % 2 == 1)
var odds = Enumerable.Range(start: 1, count: 30).Where(e => e % 2 == 1);
odds.Dump();

// Use Select to increment by another value

var fives = Enumerable.Range(start: 0, count: 30).Select(n => n * 5);
fives.Dump("Select: + 5");

var countDown = Enumerable.Range(0, 10)
													.Select(n => 10 - n);
													
countDown.Dump("Select: Count down");

// double value, use Select to transform
IEnumerable<double> doubles = odds.Select(n => n * 0.5);

doubles.Dump("Select: Convert to  double.");

