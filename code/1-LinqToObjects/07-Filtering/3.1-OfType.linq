<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\CardLib\CardLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\CardLib\CardLib.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
</Query>

// OfType operator is used to return only the elements of a specified type.
//var allCards = from card in CardLib.CardSource.Cards
//							 select card;

var allCards = CardLib.CardSource.Cards;
var passThrough = allCards.OfType<CardLib.Cards.Card>();

var monstersOnly = from card in allCards.OfType<CardLib.Cards.Robot>()
									 select card;

var interfaceOnly = from card in CardLib.CardSource.Cards.OfType<ISerializable>()
										select card;

passThrough.Select(c => new { c.Name, c.TypeName, c.BaseClassName }).Dump();
monstersOnly.Select(c => new { c.Name, c.ListPrice, c.TypeName, c.BaseClassName}).Dump();
interfaceOnly.Select(c => c).Dump();