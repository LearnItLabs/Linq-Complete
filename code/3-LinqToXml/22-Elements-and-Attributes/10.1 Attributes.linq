<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

collectibles.Element("Card").Attributes().Dump("All Card Attributes");


 collectibles.Elements("Card").Attributes()
 .OrderBy(c=>c.Name.ToString()).ThenBy(c => c.Value).Dump();