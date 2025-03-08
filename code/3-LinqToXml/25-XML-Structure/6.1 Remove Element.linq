<Query Kind="Statements" />

#region Load CardSimple xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"CardSimple.xml";
var card = XElement.Load(root + upPath + path);
#endregion

card.DumpFormatted("Original");
card.Element("Prices").Remove();

card.DumpFormatted("Modified");