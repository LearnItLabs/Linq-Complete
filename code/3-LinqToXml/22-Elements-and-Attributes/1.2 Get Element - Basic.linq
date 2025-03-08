<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion


XElement firstCard = collectibles.Element("Card").Element("Slogan");
firstCard.Dump();


XNode nextCard = firstCard.NextNode; // return the next sibling (in this example, the next XElement)

nextCard.Dump();

nextCard = nextCard.NextNode; // return the 3rd sibling (in this example, the next XElement)

nextCard.Dump();