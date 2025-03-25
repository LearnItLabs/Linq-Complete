<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use the LINQ query operators and query expression syntax.
// get attribute values

var q1 = from att in collectibles.Elements("Card").Attributes("rarity")
		 		 select att;

q1.Dump();

var q2 = from att in collectibles.Elements("Card").Attributes("rarity")
				 select att.Value;

q2.Dump();




