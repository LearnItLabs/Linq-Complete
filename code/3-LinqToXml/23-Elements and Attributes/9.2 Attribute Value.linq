<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// return the attribute name-value pair
collectibles.Element("Card").Attribute("team-name").Dump("team-name attribute");

collectibles.Element("Card").Attribute("team-name").Value.Dump("team-name value");