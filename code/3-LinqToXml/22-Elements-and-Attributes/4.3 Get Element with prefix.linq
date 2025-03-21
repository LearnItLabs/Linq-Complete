<Query Kind="Statements" />

#region Load BigStar-WithPrefix.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar-WithPrefix.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// xmlns:bigstar="http://bigstarcollectibles.com/course-examples"

// Remember, we have to use the URI, not the XML prefix.
// GetNamespaceOfPrefix helps

XNamespace ns = collectibles.GetNamespaceOfPrefix("bigstar");
// use the .Element to get a single element by name

//collectibles.Dump();
var firstCard = collectibles.Element(ns + "Card");
firstCard.Dump("The Card");
