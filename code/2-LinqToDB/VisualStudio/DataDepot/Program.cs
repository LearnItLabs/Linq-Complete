using BigStarLib.Models;
using ToursLib.Models;

namespace DataDepot {
	internal class Program {
		static void Main(string[] args) {

			// LINQ to Objects
			var colors = new List<string>{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgundy","Purple", "White", "Black", "Blue" ,"Bronze"};
			var firstColor = colors.First();
			Console.WriteLine(firstColor);

			// LINQ to Entities
			var db1 = new NorthwindLib.Models.NorthwindDbContext();
			var firstShipper = db1.Shippers.First();
			Console.WriteLine(firstShipper.CompanyName);

			var db2 = new ToursDbContext();
			var color2 = colors.ElementAt(3);
			var tip = db2.TravelTips.ElementAt(3);
			Console.WriteLine(tip.Headline);

			var db3 = new BigStarLib.Models.BigStarDbContext();
			var bColors = from c in colors
										where c.StartsWith("B")
										orderby c
										select c;
			var cards = from c in db3.CollectibleCards
									where c.TeamName == "BlueShadows"
									orderby c.CardName
									select c;

			foreach (var card in cards)
			{

				Console.WriteLine("  " + card.CardName);
			}
		}
	}
}
