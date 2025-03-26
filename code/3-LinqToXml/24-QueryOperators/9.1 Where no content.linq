<Query Kind="Statements" />

#region Load BigStarCollectibles-MissingXML xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar-MissingXML.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// XML file contains empty elements.
// It also contains elements with zero length content.

var q = from card in collectibles.Elements()
		let pubElement = card.Element("PublishedDate")
		let pubValue = pubElement.Value

		select new
		{
			CardName = card.Attribute("card-name").Value,
			PublishedDate = pubValue,
			
			PublishedElement = pubElement,
		
			PublishedIsEmpty = pubElement.IsEmpty,
			ZeroLength = String.IsNullOrEmpty(pubValue)
		};

	q.Dump();
