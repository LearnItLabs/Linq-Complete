<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar-WithPrefix.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// An attribute is not considered a child of its parent element.
// An attribute never inherits the namespace of its parent element. 
// For that reason an attribute is only in a namespace if it has a proper namespace prefix. 
// To repeat: An attribute without a prefix is never in a namespace. 

XNamespace ns = "http://bigstarcollectibles.com/course-examples";


// when the XML data uses a XSD schema namespace, 
// the code must use the namespace to fully qualify the request for the element.
var theCard = collectibles.Element(ns + "Card");


XAttribute cardnameAttribute = theCard.Attribute("card-name");
cardnameAttribute.Dump();

// edit the rarity attribute in the XML file to have a prefix
XAttribute rarityAttribute = theCard.Attribute(ns + "rarity");
rarityAttribute.Dump();


 theCard.Dump("The Card - with namespace string");
