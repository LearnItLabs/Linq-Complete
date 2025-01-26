<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// get element by ordinal value

XElement firstCard = collectibles.Element("Card");
firstCard.Dump("First");

XElement firstCardAgain = collectibles.Elements().ElementAt(0);
firstCardAgain.Dump("First Again");

XElement thirdCard = collectibles.Elements().ElementAt(2);
thirdCard.Dump("Third");