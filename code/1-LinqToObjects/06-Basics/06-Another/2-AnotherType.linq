<Query Kind="Program">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

void Main()
{
	// select returns a sequence of the chosen type
	// IEnumerable<string>, IEnumerable<Product>
	//

	// In other cases, return a sequence of different type


	var q1 = from color in ColorLib.ColorSource.WebColors
					 orderby color.ColorName
					 select new SimpleColor { ColorCategory = color.ColorFamily.ToString(), Hexadecimal = color.HexValue };

	q1.Dump("IEnumerable<SimpleColor>");

}

// Define other methods and classes here
public class SimpleColor
{

	public string ColorCategory { get; set; }
	public string Hexadecimal { get; set; }
	public bool IsPrimaryColor { get; set; }
}