<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// get child element

var monsterElement = collectibles.Element("Card").Element("Monster");

monsterElement.Dump("Monster elements");

monsterElement.Element("EyeCount").Dump("EyeCount only");
monsterElement.Element("Antenna").Dump("Antenna only");