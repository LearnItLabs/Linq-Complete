<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
	var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml"; // 
var collectibles = XElement.Load(root + upPath + path);
#endregion

// To retrieve an element, we typically need to fully qualify its name 
// using the namespace URI when a namespace is defined.
// However, BigStar.xml uses a null namespace, 
// so we can access the element directly without specifying a namespace.


var theCard1 = collectibles.Element("Card");
theCard1.Dump("The Card - without namespace");

XNamespace ns1 = "";


// Use the empty string as the namespace!
var theCard2 = collectibles.Element(ns1 + "Card");
theCard2.Dump("The Card - with namespace string");

// or 

XNamespace ns2 = collectibles.GetDefaultNamespace();
var theCard3 = collectibles.Element(ns2 + "Card");
theCard3.Dump("The Card - with GetDefaultNamespace()");




