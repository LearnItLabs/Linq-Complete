<Query Kind="Statements" />

#region Load BigStar.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"BigStar.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// card-family
// SelectMany flattens the hierarchy by combining the card-name attributes 
// from all elements in the teams group into a single collection
var q1 = from card in collectibles.Elements()
		 group card by card.Attribute("card-family").Value
		 into teams
		 let count = teams.Count()
		 orderby count
		 
		 select new
		 {
		 	Count = count,
			Team = teams.Key,
		 	TeamCollection =  teams.Select(t =>t.Attribute("card-name") )		
		 }
		 ; 

q1.Dump();