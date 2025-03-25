<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use Order by clause
var q = from card in collectibles.Elements()
		let bid = card.Element("Prices").Element("BidPrice")
		let cat = card.Element("Prices").Element("CatalogPrice")
		let bidParsed = decimal.Parse(bid.Value)
		let catParsed = decimal.Parse(cat.Value)
		 
		orderby bidParsed descending
		select new
		{
			CardName = card.Attribute("card-name").Value,
			CatalogPrice = cat.Value,
			BidPrice = bid.Value
			

		};

q.Dump();