<Query Kind="Statements">
  <NuGetReference>morelinq</NuGetReference>
  <Namespace>MoreLinq</Namespace>
</Query>

var numbers = new List<int> { 1, 3, 5, 7 };


// Returns a sequence of elements in random order from the original sequence.
var resultA = numbers.Shuffle();
resultA.Dump();

// Generates a sequence of lists that represent the permutations of the original sequence
var resultB = numbers.Permutations();

resultB.Dump();