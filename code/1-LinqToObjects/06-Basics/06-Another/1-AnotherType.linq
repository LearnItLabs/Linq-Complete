<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>


// use select to return a sequence of different type


var q1 = from color in ColorLib.ColorSource.WebColors
				 select color.BlueValue;
						
q1.Dump("IEnumerable<int>");

var q2 = from color in ColorLib.ColorSource.WebColors
				 select color.ColorName;

q2.Dump("IEnumerable<string>");