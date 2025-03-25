<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use the aggreate query operators
var q = from card in collectibles.Elements()
				let bid = card.Element("Prices").Element("BidPrice")

				where decimal.Parse(bid.Value) > 12.00M
				select new
				{
					CardName = card.Attribute("card-name").Value,
					BidPrice = decimal.Parse(bid.Value)


				};

q.Dump();
q.Sum(x => x.BidPrice).Dump("Sum");
q.Average(x => x.BidPrice).Dump("Average");
q.Count().Dump("Count");
q.Count(x => x.BidPrice > 18.0M).Dump("Count, with expression");
