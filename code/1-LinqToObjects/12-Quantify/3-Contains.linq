<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// Contains:  return whether a specified item is contained in the sequence.
// takes a object as a parameter
	var numbers = new List<int> { 24, 18, 16, 76, 14, 24, -10 };
	var containsNumber = numbers.Contains(14);

	containsNumber.Dump("Contains 14");

	var colors = ColorLib.ColorSource.WebColors;
	var colorRef1 = new ColorLib.WebColor { ColorName = "DirtBrown",
																					ColorFamily = ColorLib.ColorFamily.Brown};
	var colorRef2 = colors.ElementAt(101);

	var containsBrown = colors.Contains(colorRef1);
	containsBrown.Dump("Contains DirtBrown");

	var containsOther = colors.Contains(colorRef2);
	containsOther.Dump("Contains Other");