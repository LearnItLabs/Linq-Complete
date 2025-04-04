<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// add the content of current XML tree into
// a new parent element

collectibles.DumpFormatted("Original");

var existingCardElements = collectibles.Elements("Card");

// add existing nodes to the new <Cards> element
collectibles.Add(new XElement("Cards",existingCardElements));

// remove the existing element from the <Collectibles> element
existingCardElements.Remove();

collectibles.DumpFormatted("Modified");
