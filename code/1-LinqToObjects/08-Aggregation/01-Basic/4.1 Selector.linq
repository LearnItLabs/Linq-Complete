<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// In the context of LINQ aggregate operators, 
// selectors refer to functions or expressions 
// that specify which property or value should be used in the aggregation process. 
// They transform or project elements from a data source 
// into the specific value needed for the calculation.

// Selectors are commonly used with LINQ methods such as Min(), Max(), Sum(), and Average().

var allColors = ColorLib.ColorSource.WebColors;

// var sum = allColors.Sum(c => c ); // LINQ does not know how to sum this sequence!

var sum = allColors.Sum(c => c.RedPercent ); // Choose the propery to sum with a 'Selector'

sum.Dump("Sum of Red Percent");

var mean = allColors.Average(c => c.RedPercent);

mean.Dump("Average of Red Percent");

