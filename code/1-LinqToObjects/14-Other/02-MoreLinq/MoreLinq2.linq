<Query Kind="Statements">
  <NuGetReference>morelinq</NuGetReference>
  <Namespace>MoreLinq</Namespace>
</Query>

// LINQ provides many useful Enumerable methods.

// Many are implemented as Extension methods
// It's possible to create more extension methods to add other query operations..

// MoreLinq is available as a NuGet package https://morelinq.github.io/
// Examples at https://github.com/morelinq/examples
;
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7,8,9,10,11 };

// A.The zero-based index identifying the first element in the range of elements to move.
// B.The count of items to move.
// C.The index where the specified range will be moved.
var resultA = numbers.Move(0,3,4);

resultA.Dump();

var resultB = numbers.Move(5,1,2);

resultB.Dump();