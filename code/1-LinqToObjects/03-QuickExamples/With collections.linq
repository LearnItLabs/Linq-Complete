<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>


// The WebColors property is a List<WebColor>
// List<T> implements IEnumerable, so we can query the data.

// Phase 1 : Get/initialize the data source.
var webColors = ColorLib.ColorSource.WebColors;


// Phase 2: Write the query code.
// This is using a query expression.
var q = from color in webColors
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

// Phase 3 : Run the query.
q.Dump();

// this is using the query operator directly.
webColors.Count().Dump("Total colors");

