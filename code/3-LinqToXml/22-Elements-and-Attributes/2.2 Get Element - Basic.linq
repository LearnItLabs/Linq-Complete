<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Get nested element by calling .Element on the the parent element.
// Chain these calls
// If <Card> or <Slogan> elements don't exist, the methods will return null.
XElement firstSlogan = collectibles.Element("Card").Element("Slogan");
firstSlogan.Dump();


XNode nextElement = firstSlogan.NextNode; // return the next sibling (in this example, the next XElement)

nextElement.Dump();

nextElement = nextElement.NextNode; // return the 3rd sibling (in this example, the next XElement)

nextElement.Dump();