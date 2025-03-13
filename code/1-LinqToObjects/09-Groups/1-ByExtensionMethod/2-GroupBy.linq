<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// GroupBy returns a sequence of groups
// Each group has a 'key' and a value'
// GroupBy uses an expression to determine the group 'key'
// and which sequence items belong in that group
// the 'value' is the sequence of items in the group

// Let's start with the GroupBy extension method

	var colors = ColorLib.ColorSource.WebColors;
	var groupedResult = colors.GroupBy(c => c.ColorName[0] ).OrderBy(g => g.Key);

groupedResult.Dump();
