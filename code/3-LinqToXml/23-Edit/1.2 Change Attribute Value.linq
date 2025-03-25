<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use SetAttributeValue to work with the "team-name" attribute
XElement cardElement = collectibles.Element("Card");
var teamAttribute = cardElement.Attribute("team-name");
cardElement.Attributes().Dump("All Card attributes");

// Update the "team-name" attribute using SetAttributeValue
cardElement.SetAttributeValue("team-name", "DarkShadows");
cardElement.SetAttributeValue("rarity", "Common");

cardElement.Attributes().Dump("Modified Card attributes");

