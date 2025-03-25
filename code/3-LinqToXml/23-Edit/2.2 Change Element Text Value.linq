<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// returns the XML data (including the element tags)
// Elements can contain content, or other elements
var monsterElement = collectibles.Element("Card").Element("Monster");

monsterElement.Dump();
monsterElement.Value.Dump("Monster value");
// change the value
monsterElement.Value= "Replace Everything";

monsterElement.Dump("Modified Monster element");
monsterElement.Value.Dump("Modified Monster value");

