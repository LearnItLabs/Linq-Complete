<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// select returns a sequence of the chosen type
// IEnumerable<string>, IEnumerable<Product>
//

// In many cases, this is the same type as original sequence
// in this example, its a list of same type

	var q = from color in ColorLib.ColorSource.WebColors
						orderby color.ColorFamily
					select color;

	q.Dump();

//
//var q = from color in ColorLib.ColorSource.WebColors
//				where color.ColorFamily == ColorLib.ColorFamily.Orange
//				select color;