<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>


// The WebColors property is a List<WebColor>
// List<T> implements IEnumberable, so we can query the data.

ColorLib.ColorSource.WebColors.Count().Dump("Total colors");
var q = from color in ColorLib.ColorSource.WebColors
				where (color.ColorFamily == ColorLib.ColorFamily.Purple) // filter

				orderby color.ColorFamily// Orderby
				// type projection, create new type with property names we want.
				select new {
					color.ColorName,
					HexCode = color.HexValue,
					BlueAmount = color.BlueValue ,
					RedAmount = color.RedValue,
					GreenAmount = color.GreenValue
				};

q.Dump();

