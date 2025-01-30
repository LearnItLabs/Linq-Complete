<Query Kind="Statements">
  <Namespace>System.Numerics</Namespace>
</Query>

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var xDoc = XDocument.Load(root + upPath + path);
var xElem = XElement.Load(root + upPath + path);
#endregion

// Get some of the document info

xDoc.Declaration.ToString().Dump("The declaration string");
xDoc.Declaration.Dump("The declaration object");
