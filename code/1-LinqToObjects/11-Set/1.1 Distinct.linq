<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

List<int> numbers = new List<int>{ 1, 2, 2, 1, 3, 5, 5, 6 };

var q = numbers.Distinct();

numbers.Dump();
q.Dump();

// use select to specify what property to evaluate for distinct
var distinctColors = ColorLib.ColorSource.WebColors.Select(x=>x.HexValue).Distinct();

distinctColors.Dump();