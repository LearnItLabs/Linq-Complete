<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar-WithPrefix.xml";
var cDoc = XDocument.Load(root + upPath + path);

#endregion

/* 
   Get document meta-data
*/ 
cDoc.Declaration.Dump("Declaration");

cDoc.Declaration.Encoding.Dump();

