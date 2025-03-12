<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\CardLib\CardLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\CardLib\CardLib.dll</Reference>
</Query>

// A new datasource
// from a .NET assembly DLL

// see the visual studio project to examine the code

// be sure and add a reference to the DLL (Press F4 in LINQPad)
// ..\code\Data\Assemblies\CardLib

	CardLib.CardSource.Cards.Dump();