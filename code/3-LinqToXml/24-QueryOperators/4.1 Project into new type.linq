<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// use the LINQ Query operators and syntax
// collectibles.Dump();
var q = from card in collectibles.Elements()
				let bid = card.Element("Prices").Element("BidPrice")
				let cat = card.Element("Prices").Element("CatalogPrice")

				select new {
					CardName = card.Attribute("card-name").Value,
					BidPrice = bid.Value,
					CatalogPrice = cat.Value,

				};

q.Dump();
// alternate syntax, could be slower, due to .Descendants searching through elements.
var q2 = from card in collectibles.Elements()
				
				 select new {
					 CardName = card.Attribute("card-name").Value,
					 BidPrice = card.Descendants("BidPrice").ElementAt(0).Value,
					 CatalogPrice = card.Descendants("CatalogPrice").First().Value,

				 };
q2.Dump();
