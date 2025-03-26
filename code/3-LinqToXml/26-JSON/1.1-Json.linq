<Query Kind="Statements">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

// Sample JSON string
string json = @"{
            'cards': [
                { 'cardName': 'BlueCard', 'team': 'Spooktones', 'price': 10.5 },
                { 'cardName': 'YellowCard', 'team': 'Crashmasters', 'price': 15.0 },
								{ 'cardName': 'OrangeCard', 'team': 'Crashmasters', 'price': 12.0 },
                { 'cardName': 'CrimsonCard', 'team': 'Spooktones', 'price': 8.75 }
            ]
        }";

// Parse JSON into a JObject
JObject jsonObject = JObject.Parse(json);

// Query JSON data using LINQ
var q = from card in jsonObject["cards"]
				where (string)card["team"] == "Spooktones"
				select new
				{
					Name = (string)card["cardName"],
					Price = (double)card["price"]
				};

q.Dump();