<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion


collectibles.Elements().Dump("All");
var robots = collectibles.Elements().Where(x =>x.Attribute("card-family").Value=="Robot" );
		
robots.Dump("Robots Only");

robots.Remove();

collectibles.Elements().Dump("Removed the Robots");