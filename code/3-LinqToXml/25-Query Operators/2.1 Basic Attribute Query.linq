<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// use the LINQ Query operators and syntax
// get attributes
collectibles.Element("Card").Dump();
var q1 = from att in collectibles.Element("Card").Attributes()
		 select att;

q1.Dump();



