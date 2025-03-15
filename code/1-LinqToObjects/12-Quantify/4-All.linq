<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
  <Reference Relative="..\..\..\..\LearnItLabs\Linq-Complete\code\1-LinqToObjects\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\1-LinqToObjects\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// All: returns whether all the elements in the input sequence 
// match the given predicate 
//var colors = ColorLib.ColorSource.WebColors;

	var numbers = new List<int> { 24, 18, 16, 76, 14, 24 ,-10};

	var areEven = numbers.All(x => x % 2 == 0);

	areEven.Dump("All are even numbers.");

	var hasTwoDigits = numbers.All(n => Math.Floor(Math.Log10(Math.Abs(n)) + 1) == 2);

	hasTwoDigits.Dump("All have two digits.");