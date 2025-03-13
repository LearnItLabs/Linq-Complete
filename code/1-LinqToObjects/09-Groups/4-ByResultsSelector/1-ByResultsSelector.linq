<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// Change the key name or value name 
// with the resultSelector
var colors = ColorLib.ColorSource.WebColors;
// use result selector to customize the generated sequence
var group = 
colors.GroupBy(keySelector: x => x.ColorFamily,
							 elementSelector: y => new { y.ColorName, y.HexValue },
							 resultSelector: (key, value) => new {Family= key, Colors= value });

group.Dump();