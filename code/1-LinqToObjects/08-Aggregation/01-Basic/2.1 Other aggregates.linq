<Query Kind="Statements" />

// The common LINQ aggregate operations
var numbers = new List<int> { 50, 4, 10, 3, 90, 8, -60, 7, 20, 5 };
int[] numArray = { 21, 19, 17, 15, 13 };
var total = numbers.Sum();
var mean = numArray.Average();

var lowest = numbers.Min();
var highest = numbers.Max();



total.Dump("Sum");
mean.Dump("Average");
lowest.Dump("Min");
highest.Dump("Max");
