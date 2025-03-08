<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// use the .Element to get a single element by name
// gets the first matching element
// collectibles.Dump();

XElement firstCard = collectibles.Element("Card");
firstCard.Dump();


XNode nextCard = firstCard.NextNode; // return the next sibling (in this example, the next XElement)

nextCard.Dump();

nextCard = nextCard.NextNode; // return the 3rd sibling (in this example, the next XElement)

nextCard.Dump();