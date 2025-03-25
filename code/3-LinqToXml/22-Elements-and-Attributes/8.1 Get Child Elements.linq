<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// elements returns child collection


// .Elements() returns a "Filtered" collection!
var slogans = collectibles.Elements("Card").Elements("Slogan");
slogans.Dump();

var monsters =collectibles.Elements("Card").Elements("Monster");
monsters.Dump();