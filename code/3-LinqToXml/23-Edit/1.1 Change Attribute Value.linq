<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// return the attribute name-value pair
XAttribute teamnameAttribute = collectibles.Element("Card").Attribute("team-name");
teamnameAttribute.Dump("team-name attribute");

teamnameAttribute.Value.Dump("team-name value");

teamnameAttribute.Value = "DarkShadows";
teamnameAttribute.Dump("team-name attribute");


teamnameAttribute.Value.Dump("Modified team-name value");