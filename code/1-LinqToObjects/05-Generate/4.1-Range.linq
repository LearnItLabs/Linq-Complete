<Query Kind="Statements" />

// Range:
// Generates a sequence of integral numbers within a specified range.

var numbers = Enumerable.Range(start: 1000, count: 30);

numbers.Dump();

numbers = Enumerable.Range(start: -50, count: 6);

numbers.Dump();

