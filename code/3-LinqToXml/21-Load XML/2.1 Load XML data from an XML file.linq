<Query Kind="Statements" />

// A collectible is something of value either in a collection or to a collector.
// Big Star Collectibles trades and sells collectible items.
// Big Star uses data in XML files
	
	var root = Path.GetDirectoryName(Util.CurrentQueryPath);
  var upPath = @"\..\..\Data\XML\";
	var path = @"BigStar.xml";
	var loaded = XElement.Load(root + upPath + path);
	
// ** Why XElement instead of XmlElement? **
// The XmlElement name is from earlier XML libraries, 
// which is why it's not used in this context. 
// Instead, newer .NET XML handling uses classes like XElement under the LINQ to XML model, 
// which provide enhanced capabilities and integration with LINQ queries.

	Console.WriteLine(loaded);

	//loaded.Dump("Add at title here");