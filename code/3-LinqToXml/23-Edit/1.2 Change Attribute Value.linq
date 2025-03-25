<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use SetAttributeValue to work with the "team-name" attribute
XElement cardElement = collectibles.Element("Card");


var teamnameValue = cardElement.Attribute("team-name");
cardElement.Attributes().Dump("all Card attributes");

// Update the "team-name" attribute using SetAttributeValue
cardElement.SetAttributeValue("team-name", "DarkShadows");

// Dump the updated "team-name" attribute value
string modifiedTeamnameValue = cardElement.Attribute("team-name").Value;
cardElement.Attributes().Dump("Modified Card attributes");

