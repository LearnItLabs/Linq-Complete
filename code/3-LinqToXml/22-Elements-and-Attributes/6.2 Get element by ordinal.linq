<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use LINQ query operators on collection


var slogans = collectibles.Elements("Card").Elements("Slogan");
slogans.ElementAt(1).Dump("Second");

slogans.ElementAt(3).Dump("Fourth");

slogans.Last().Dump("Last");

var catPrices = collectibles.Elements("Card").Elements("Prices").Elements("CatalogPrice");
catPrices.Dump();