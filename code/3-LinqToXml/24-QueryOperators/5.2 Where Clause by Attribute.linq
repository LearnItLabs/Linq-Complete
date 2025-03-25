<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// collectibles.Dump();
var q = from card in collectibles.Elements()
				where card.Attribute("card-family").Value == "Robot"
				select new
				{
					CardName = card.Attribute("card-name").Value,
					TeamName = card.Attribute("team-name").Value,
					ElementName = card.Element("Slogan").Name,
					Family = card.Attribute("card-family").Value
				};

q.Dump();