<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion


XElement cardElement = collectibles.Element("Card");


var  teamnameValue = cardElement.Attribute("team-name");
cardElement.Attributes().Dump("all Card attributes");

// if attribute doesn't exist,  it is created 
cardElement.SetAttributeValue("limited-edition", "true");

// if attribute value set to null, it is removed
cardElement.SetAttributeValue("rarity", null);
cardElement.Attributes().Dump("Modified Card attributes");
