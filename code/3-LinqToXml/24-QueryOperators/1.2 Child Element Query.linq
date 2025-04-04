<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use the LINQ query operators and query expression syntax.
// Get child elements
var q1 = from card in collectibles.Elements()
		     select card.Element("Prices").Element("BidPrice");

q1.Dump();

var q2 = from bid in collectibles.Descendants("BidPrice")
		     select bid;

q2.Dump();