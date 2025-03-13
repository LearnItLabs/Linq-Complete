<Query Kind="Statements" />

// The common LINQ aggregate operations
var numbers = new List<int> { 50, 4, 10, 3, 90, 8, -60, 7, 20, 5 };
int[] numArray = { 21, 19, 17, 15, 13 };


// Enumerable.Count(): Is an aggregate operation too.

// Why not use Array.Length or List.Count
// - Using List<T>.Count directly accesses the property, 
//   providing efficient access.
// - Using Enumerable.Count() iterates through the collection, 
//   which can be less efficient for large arrays or lists.

var countOf = numbers.Count; // calls the List<T> Count
countOf = numbers.Count();   // calls calls the Enumerable.Count() 

var anotherCountOf = numArray.Length; // calls the array Length property
anotherCountOf = numArray.Count(); // calls the Enumerable.Count() 


// .Count is the provided LINQ because it works with both 
//  in-memory collections and queryable data sources


countOf.Dump("Count List<T>");
anotherCountOf.Dump("Count Array");