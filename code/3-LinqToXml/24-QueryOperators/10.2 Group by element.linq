<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion
// group by Element
var q1 = from price in collectibles.Descendants("Prices")
				 group price by price.Element("CatalogPrice").Value
				 
				 into catPrices
				 orderby catPrices.Key descending
				 select new {catPrices.Key, catPrices};	

q1.Dump();

