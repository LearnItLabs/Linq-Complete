<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// Where:  any valid boolean expression is acceptable

// Use &&, &, ||, | , !, ^


var q1 = from color in ColorLib.ColorSource.WebColors
				where color.ColorFamily == ColorLib.ColorFamily.Orange
				&& color.ColorName.Contains("")
				select color;


q1.Dump("&&");

var q2 = from color in ColorLib.ColorSource.WebColors
				 where color.ColorFamily == ColorLib.ColorFamily.Blue
				 ||    color.ColorFamily == ColorLib.ColorFamily.Yellow
				 select color;


q2.Dump("||");