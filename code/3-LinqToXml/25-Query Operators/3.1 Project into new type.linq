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
		
		
		select new
		{
			CardName = card.Attribute("card-name").Value,
			BidPrice = bid.Value,
			CatalogPrice = cat.Value,
			
		};

q.Dump();