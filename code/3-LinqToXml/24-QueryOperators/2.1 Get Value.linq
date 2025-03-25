<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use the LINQ query operators and query expression syntax.

var q1 = from bid in collectibles.Descendants("BidPrice")
		     select bid;

q1.Dump();

var q2 = from bid in collectibles.Descendants("BidPrice")
		     select bid.Value; // returns the value as string.

q2.Dump();

var q3 = from bid in collectibles.Descendants("BidPrice")
				 select decimal.Parse(bid.Value); //cast to decimal.

q3.Dump();