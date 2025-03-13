<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\CardLib\CardLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\CardLib\CardLib.dll</Reference>
</Query>

//In the context of LINQ aggregate operators, 
// selectors refer to functions or expressions 
// that specify which property or value should be used in the aggregation process. 
// They transform or project elements from a data source 
// into the specific value needed for the calculation.

// Selectors are commonly used with LINQ methods such as Min(), Max(), Sum(), and Average().

var robots = CardLib.CardSource.Cards.OfType<CardLib.Cards.Robot>();

var max = robots.Max(c => c.BatteryLevel ); // Choose the propery to sum with a 'Selector'
var min = robots.Min(c => c.BatteryLevel );

max.Dump("Highest battery level");
min.Dump("Lowest battery level");


