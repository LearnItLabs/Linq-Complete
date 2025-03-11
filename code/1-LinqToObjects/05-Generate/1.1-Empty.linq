<Query Kind="Statements" />

// The Enumerable class in LINQ provides various methods 
// to generate sequences that implement IEnumerable<T>.

// Empty : Returns a zero length IEnumerable<T>
// Useful for avoiding null references, 
// initializing sequences, and providing empty parameters for methods

var listOfDates1 = Enumerable.Empty<DateTime>();

listOfDates1.Count().Dump("Count");
listOfDates1.Dump("IEnumerable<DateTime> contents");

