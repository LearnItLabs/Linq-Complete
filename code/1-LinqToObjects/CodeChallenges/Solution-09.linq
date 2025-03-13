<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

var colors = ColorLib.ColorSource.WebColors;

var q1 = from color in colors
				 group color by Math.Round(color.RedPercent, 2); // key selector


var q2 = from color in colors
				group color by new { color.BlueValue, color.GreenValue}; // key selector




q1.Dump();
//q2.Dump();