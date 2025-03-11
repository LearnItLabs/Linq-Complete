<Query Kind="Statements" />

// The Enumerable class in LINQ provides various methods 
// to generate sequences that implement IEnumerable<T>.

// Empty : Returns a zero length IEnumerable<T>
// Useful for avoiding null references, 
// initializing sequences, and providing empty parameters for methods


var listOfDates1 = Enumerable.Empty<DateTime>();

listOfDates1.GetType().Name.Dump("listOfDates1 Type");
// EmptyPartition is an internal implementation detail in LINQ 
// that represents an empty sequence. 
// When you use Enumerable.Empty<T>(), it returns an instance of an EmptyPartition<T>, 
// which implements IEnumerable<T> but does not contain any elements.
listOfDates1.Count().Dump("Count");
listOfDates1.Dump("IEnumerable<DateTime> contents");

List<DateTime> listOfDates2 = Enumerable.Empty<DateTime>().ToList();
// Calling .ToList() on an EmptyPartition<T> effectively converts 
// the empty sequence into a List<T>. Since EmptyPartition<T> represents an empty sequence, 
// the resulting list will also be empty.

listOfDates2.GetType().Name.Dump("listOfDates2 Type");
listOfDates2.Dump();