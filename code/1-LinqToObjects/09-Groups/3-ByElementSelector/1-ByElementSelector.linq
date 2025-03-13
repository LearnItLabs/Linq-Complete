<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>


var colors = ColorLib.ColorSource.WebColors;
// use element selector to specify what properties on the members of the group

var grouped = colors.GroupBy(keySelector: x => x.ColorFamily,
														 elementSelector: y => new { y.ColorName, y.HexValue });

grouped.Dump();