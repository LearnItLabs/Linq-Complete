<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// to simplify examples in the remainder of the course
// we'll use the null namespace file.

// Element returns a single element

XElement firstSlogan = collectibles.Element("Card").Element("Slogan");
//firstCard.Dump();

// Elements returns a collection of child elements
var slogans = collectibles.Elements("Card").Elements("Slogan");
slogans.Dump();