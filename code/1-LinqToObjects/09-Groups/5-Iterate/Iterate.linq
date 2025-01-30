<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// Work with a nested group sequence

var colors = ColorLib.ColorSource.WebColors;
// use result selector to customize the generated sequence
var grouped = colors.GroupBy(keySelector: x => x.ColorFamily,
								elementSelector: y => new { y.ColorName, y.HexValue },
								resultSelector: (key, value) => new { Family = key, Colors = value });


// how to access without .Dump

foreach (var group in grouped)
{

	Console.WriteLine(group.Family);
	foreach (var color in group.Colors)
	{
		Console.WriteLine($"    {color.ColorName}");
	}
	
	Console.WriteLine();
}