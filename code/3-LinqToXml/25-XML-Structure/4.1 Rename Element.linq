<Query Kind="Statements" />

#region Load CardSimple xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"CardSimple.xml";
var card = XElement.Load(root + upPath + path);
#endregion

card.Dump("Original");


card.Element ("PublishedDate").Name = "ReleaseDate";
card.Dump("Modified");