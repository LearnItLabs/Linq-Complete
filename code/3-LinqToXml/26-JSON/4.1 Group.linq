<Query Kind="Statements">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

#region Load BigStar.json file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\JSON\";
var path = @"BigStar.json";
JObject collectibles = JObject.Parse(File.ReadAllText(root + upPath + path));


#endregion

//collectibles.Dump();
// Query the JSON using LINQ

var q = from card in collectibles["Collectibles"]["Card"]
				let cat = card["Prices"]["CatalogPrice"]
				let cardShort = new {
					CardName = (string)card["CardName"],
					CatalogPrice = (string)cat
				}
				 group cardShort by cardShort.CatalogPrice
				 into catGroup
				 orderby catGroup.Key descending
				select new { PriceKey = catGroup.Key, CardName = catGroup.Select(g => g.CardName) };
q.Dump();

// This is the XML syntax
//var q1 = from card in collectibles.Elements()
//				 let cat = card.Descendants("CatalogPrice")
//				 let cardShort = new {
//					 CardName = card.Attribute("card-name").Value,
//					 CatalogPrice = cat.First().Value
//				 }
//				 group cardShort by cardShort.CatalogPrice
//
//				 into catGroup
//				 orderby catGroup.Key descending
//				 select new { PriceKey = catGroup.Key, CardName = catGroup.Select(g => g.CardName) };