<Query Kind="Statements" />

#region Load BigStar-Default-NS file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
	var upPath = @"\..\..\Data\XML\";
var path = @"BigStar-Default-NS.xml"; // null namespace
var collectibles = XElement.Load(root + upPath + path);
#endregion

// To retrieve an element, we typically need to fully qualify its name 
// using the namespace URI when a namespace is defined.
// BigStar-Default-NS.xml uses a default namespace, 
// so we must use the namespace.

XNamespace ns1 = "http://bigstarcollectibles.com/";


// If the XML data uses a namespace, 
// the code must use the namespace to fully qualify the request for the element.
var theCard1 = collectibles.Element(ns1 + "Card");
theCard1.Dump("The Card - with namespace string");


// Or get the namespace from the XElement.
XNamespace ns2 = collectibles.GetDefaultNamespace();
var theCard2 = collectibles.Element(ns2 + "Card");
theCard2.Dump("The Card - with GetDefaultNamespace()");


