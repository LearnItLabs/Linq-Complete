<Query Kind="Statements">
  <NuGetReference>morelinq</NuGetReference>
  <Namespace>MoreLinq</Namespace>
</Query>

var numbers =  Enumerable.Range (0,200);


// Returns every N-th element of a source sequence
var resultA = numbers.TakeEvery(8);
resultA.Dump();