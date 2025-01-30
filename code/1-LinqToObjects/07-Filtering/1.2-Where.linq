<Query Kind="Program">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

void Main()
{

	var q = from color in ColorLib.ColorSource.WebColors

					where IsColorTotalLessThan(color, 1.5)
					select new
					{
						color.ColorName,
						color.BluePercent,
						color.GreenPercent,
						color.RedPercent,
						TotalPercent = color.BluePercent +
													 color.GreenPercent +
													 color.RedPercent
					};

	q.OrderBy(x => x.TotalPercent).Dump();


}

// Define other methods and classes here
public bool IsColorTotalLessThan(ColorLib.WebColor color, double maxValue)
{
	var total = color.BluePercent + color.GreenPercent + color.RedPercent;

	return total < maxValue;
}