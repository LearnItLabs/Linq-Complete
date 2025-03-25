<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// get element by ordinal value

XElement firstSlogan = collectibles.Element("Card").Element("Slogan");
firstSlogan.Dump("First");

var slogans = collectibles.Elements("Card").Elements("Slogan");
slogans.ElementAt(1).Dump("Second");

slogans.ElementAt(3).Dump("Fourth");
