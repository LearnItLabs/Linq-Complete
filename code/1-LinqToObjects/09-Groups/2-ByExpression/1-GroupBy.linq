<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// Query expressions must end with a select or groupby clause!

var colors = ColorLib.ColorSource.WebColors;

var q = from color in colors
				group color by color.ColorFamily ; 

q.Dump();