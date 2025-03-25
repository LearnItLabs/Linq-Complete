<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use the LINQ query operators and query expression syntax.
// Get child elements

//var q1 = from bid in collectibles.Descendants("BidPrice")
//				 select bid;
//
//q1.Dump();

// Use query operators.

collectibles.Descendants("BidPrice").Select(b => b).Dump();

// We don't really need .Select, as methods like 
// Descendants() and Elements() already return an IEnumerable<XElement>
collectibles.Descendants("BidPrice").Dump();