<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Get the attribute name-value pair
XAttribute teamName = collectibles.Element("Card").Attribute("team-name");

teamName.Dump("team-name attribute");
teamName.Value.Dump("team-name value");

// assign a new value
teamName.Value = "DarkShadows";
teamName.Dump("modified attribute");

// use setValue method (another way to change the value)
teamName.SetValue("DreamShadows");
teamName.Value.Dump("Modified  value");
teamName.Dump("modified attribute");


teamName.Value.Dump("Modified  value");