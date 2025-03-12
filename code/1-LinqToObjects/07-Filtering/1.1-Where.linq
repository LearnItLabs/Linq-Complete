<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// The Where clause filters a sequence based on a predicate function.
// A predicate is a boolean expression that is applied to each element in the sequence.
// Only elements that satisfy the condition (return true) are included in the filtered sequence.


var q = from color in ColorLib.ColorSource.WebColors
				where (false)
				select color;
				
q.Dump();

