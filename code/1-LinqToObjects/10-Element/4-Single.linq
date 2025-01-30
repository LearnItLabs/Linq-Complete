<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// Single: Returns the only element of a sequence that satisfies 
// a specified condition, and throws an exception if more than one such element exists.

// SingleOrDefault: Returns a single, specific element of a sequence, or a default value if that element is not found.

var colors =  ColorLib.ColorSource.WebColors;
colors.Single(x => x.ColorName =="SteelBlue").Dump("Single");
colors.SingleOrDefault(x => x.ColorName =="DirtBrown").Dump("SingleOrDefault");