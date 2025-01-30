<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// var groupedByColorFamily = colors.GroupBy(keySelector: x => x.ColorFamily,
//                               elementSelector: y => new { y.ColorName, y.HexValue });
var colors = ColorLib.ColorSource.WebColors;

var q = from color in colors
				let colorShort = new { color.ColorName, color.HexValue, color.ColorFamily } 
				group colorShort by colorShort.ColorFamily // key selector
				into familyGroup // variable used in resultSelector
				// result selector
				select new { Family = familyGroup.Key, Colors = familyGroup }; 


q.Dump();