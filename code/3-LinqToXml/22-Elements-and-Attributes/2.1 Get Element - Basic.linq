<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use the .Element method to get a single element by name
// It gets the first matching element
// collectibles.Dump();

XElement firstCard = collectibles.Element("Card");
firstCard.Dump();

/* 
A sibling refers to elements that share the same parent element within the XML hierarchy.
<family>
  <parent>
    <child1>Bartle</child1> <== sibling
    <child2>Hiroki</child2> <== sibling
    <child3>Shengi</child3> <== sibling
  </parent>
</family>
*/

XNode secondCard = firstCard.NextNode; // return the next sibling (in this example, the next XElement)

secondCard.Dump();

var thirdCard = secondCard.NextNode; // return the 3rd sibling (in this example, the next XElement)

thirdCard.Dump();

// this is also a possibility
// Ugly but it works!
var fourthCard = firstCard.NextNode.NextNode.NextNode;

fourthCard.Dump();
