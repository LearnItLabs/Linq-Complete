<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion
// group by Element

var q1 = from card in collectibles.Elements()
				 let cat = card.Descendants("CatalogPrice")
				 let cardShort = new {CardName = card.Attribute("card-name").Value,
				 									    CatalogPrice = cat.First().Value}
				 group cardShort by cardShort.CatalogPrice

				 into catGroup
				 orderby catGroup.Key descending
				 select new {PriceKey=catGroup.Key, CardName = catGroup.Select(g => g.CardName) 	};

q1.Dump();

