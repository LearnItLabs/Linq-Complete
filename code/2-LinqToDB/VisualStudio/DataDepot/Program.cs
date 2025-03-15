using BigStarLib.Models;
using ToursLib.Models;

namespace DataDepot {
	internal class Program {
		static void Main(string[] args) {

			// LINQ to Objects
			var colors = new List<string>{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgundy","Purple", "White", "Black", "Blue" ,"Bronze"};
			var firstColor = colors.First();
			Console.WriteLine(firstColor);

			var db1 = new NorthwindLib.Models.NorthwindDbContext();
			var firstShipper = db1.Shippers.First();
			Console.WriteLine(firstShipper.CompanyName);

			var db2 = new ToursDbContext();
			var tip = db2.TravelTips.ElementAt(2);
			Console.WriteLine(tip.Headline);

			var db3 = new BigStarLib.Models.BigStarDbContext();

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
