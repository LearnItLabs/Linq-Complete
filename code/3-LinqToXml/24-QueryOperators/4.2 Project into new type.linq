<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// use the LINQ Query operators and syntax

// Query operator syntax
var q3 = collectibles.Elements()
										 .Select(card => new {
											 CardName = card.Attribute("card-name").Value,
											 BidPrice = card.Element("Prices").Element("BidPrice")?.Value,
											 CatalogPrice = card.Element("Prices").Element("CatalogPrice")?.Value
										 });
q3.Dump();


var q4 = collectibles.Elements()
										 .Select(card => new {
											 CardName = card.Attribute("card-name").Value,
											 BidPrice = card.Descendants("BidPrice").FirstOrDefault()?.Value,
											 CatalogPrice = card.Descendants("CatalogPrice").FirstOrDefault()?.Value
										 });
q4.Dump();

