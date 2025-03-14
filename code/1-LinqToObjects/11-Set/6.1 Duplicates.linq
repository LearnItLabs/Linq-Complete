<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// Distinct removes all the duplicate items,
// But what if you need to find them instead?

// To find duplicates, use GroupBy() to group items based on their key.
// Then, filter groups where the count is greater than one to identify repeated values.

//var hexValues = CourseLib.ColorSource.GetColors().Select(x=>x.HexValue);
//hexValues.Distinct().Dump();

var q1 = from color in ColorLib.ColorSource.WebColors
				 group color by color.HexValue into hexGroup
				 where hexGroup.Count() > 1
				 select new {HexValue = hexGroup.Key,ColorNames = hexGroup.Select(g => g.ColorName) };
q1.Dump();
 
// use extension methods

var q2 = ColorLib.ColorSource.WebColors.GroupBy(g => g.HexValue).Where(x => x.Count() > 1);

q2.Dump("Extension methods");