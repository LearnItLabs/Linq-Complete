<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion


// Use the .Attribute to get a single attribute by name
// Attribute names are unique per element.
// Think of attributes as Element properties

XAttribute theAttribute = collectibles.Element("Card").Attribute("card-name");
theAttribute.Dump();


XAttribute nextAttribute = theAttribute.NextAttribute; // return the next attribute (in this example, the next XAttribute)

nextAttribute.Dump();

nextAttribute.NodeType.Dump();