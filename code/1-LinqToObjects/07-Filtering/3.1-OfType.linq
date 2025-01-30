<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\CardLib\CardLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\CardLib\CardLib.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
</Query>

// OfType operator is used to return only the elements of a specified type.
var q = from card in CardLib.CardSource.Cards
				select card;
				
		
var monstersOnly = q.OfType<CardLib.Cards.Monster>();
//monstersOnly.Select(c => new {c.Name, c.ListPrice, c.TypeName}).Dump();
//q.OfType<ISerializable>().Dump();
q.Dump();