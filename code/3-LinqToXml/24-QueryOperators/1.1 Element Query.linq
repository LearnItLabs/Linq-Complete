<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use the LINQ query operators and query expression syntax.
// collectibles.Dump();

var q1 = from card in collectibles.Elements() // get all elements
				 select card;
		
q1.Dump();

var q2 = from card in collectibles.Elements("Card") // get all elements
				 select card;

q2.Dump();