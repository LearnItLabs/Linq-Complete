<Query Kind="Statements">
  <Reference>C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Use a sequence of integers to designate output order in another sequence .

// Original sequence of items.
List<string> foods = new List<string> { "apple", "banana", "cherry", "durian",
																	      "eggplant", "fig", "grape", "honey", "jalapeno", "kale" };
																				
// Sequence of integers representing the desired order (zero index-based)
List<int> preferredOrder = new List<int> { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

// Use the order sequence to rearrange the colors.
var q = from position in preferredOrder
				select new { Position = position, Word = foods.ElementAt(position) };

foods.Dump("Original order");
q.Dump("Indexing into another sequence");