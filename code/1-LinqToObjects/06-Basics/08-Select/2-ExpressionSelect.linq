<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// Select can use expressions to set the value


var q = from color in ColorLib.ColorSource.WebColors
				orderby color.ColorName
				select new { DetailedName = $"{color.ColorFamily}: {color.ColorName.ToString()}"};

q.Dump("Select with an expression");