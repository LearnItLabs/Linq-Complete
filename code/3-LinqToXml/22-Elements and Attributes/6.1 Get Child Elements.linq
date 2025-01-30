<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// elements returns child collection
;
collectibles.Elements("Card").Elements("Slogan").Dump("Slogans");


//collectibles.Elements("Card").Elements("")