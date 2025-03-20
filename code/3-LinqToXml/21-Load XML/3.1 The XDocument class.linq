<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var cDoc = XDocument.Load(root + upPath + path);
var cElement = XElement.Load(root + upPath + path);
#endregion

/* Most of the time, you'll load an XElement rather than the XDocument
	 The XDocument represents the entire XML content, including 
	 the Document metadata
	 
	 Use the XDocument.Root to get the root element
	 Or get it directly with XElement.Load()
*/ 
cDoc.Dump("Doc");

cElement.Dump("Element");

// cDoc.Root <== same as loading the cElement

