<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// My challenge solution
	var q = from color in ColorLib.ColorSource.WebColors
					orderby color.GreenValue descending
					select new { color.ColorName, 
					Formula = $"rgb ({color.RedValue.ToString("D3")}, {color.GreenValue.ToString("D3")}, {color.BlueValue.ToString("D3")})"};
							
q.Dump(); 