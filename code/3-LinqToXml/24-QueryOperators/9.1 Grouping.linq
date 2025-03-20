<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion
 // group by card-family
var q1 = from card in collectibles.Elements()
		 group card by card.Attribute("card-family").Value; // key selector

q1.Dump();