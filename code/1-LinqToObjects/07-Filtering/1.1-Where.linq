<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// The Where clause filters the sequence based on a predicate function
// The predicate is applied to each element in the sequence.
// define a predicate that uses a boolean expression 
// to determine what to return in filtered sequence


var q = from color in ColorLib.ColorSource.WebColors
				where (false)
				select color;
				
q.Dump();

