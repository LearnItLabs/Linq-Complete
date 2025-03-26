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

/*
This part of the query, ["Prices"]["CatalogPrice"], 
is often referred to as property chaining in the context of LINQ to JSON. 
It represents a navigation path through the JSON structure to access nested properties.
*/
var q = from card in collectibles["Collectibles"]["Card"]
				let bid = card["Prices"]["BidPrice"]
				let cat = card["Prices"]["CatalogPrice"]
				select new {
					CardName = (string)card["CardName"],
					BidPrice = (decimal)bid,
					CatalogPrice = (decimal)cat
				};
q.Dump();

q.Sum(c =>c.CatalogPrice ).Dump();