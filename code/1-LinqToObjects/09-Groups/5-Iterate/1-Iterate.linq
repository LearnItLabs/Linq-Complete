<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// Work with a nested group sequence
// Each group contains its own set of values, resulting in two levels of sequences.
// To iterate through all the data, we need at least two for-each loops.

var colors = ColorLib.ColorSource.WebColors;

var grouped = colors.GroupBy(keySelector: x => x.ColorFamily,
								elementSelector: y => new { y.ColorName, y.HexValue });


// how to access without .Dump

foreach (var group in grouped)
{

	Console.WriteLine(group.Key);
	foreach (var color in group)
	{
		Console.WriteLine($"    -{color.ColorName}");
	}
	
	Console.WriteLine();
}