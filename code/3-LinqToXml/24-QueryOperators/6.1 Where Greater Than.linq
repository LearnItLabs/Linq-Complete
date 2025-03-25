<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use LINQ query syntax and operators.
// "let" creates reusable variables in the query.
// Filters by parsed BidPrice > 12.00M.
// Selects CardName and BidPrice for output.

var q = from card in collectibles.Elements()
				let bid = card.Element("Prices").Element("BidPrice")

				where decimal.Parse(bid.Value) > 12.00M
				select new
				{
					CardName = card.Attribute("card-name").Value,
					BidPrice = bid.Value


				};

q.Dump();