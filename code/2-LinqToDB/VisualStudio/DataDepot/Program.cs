using ToursLib.Models;

namespace DataDepot {
	internal class Program {
		static void Main(string[] args) {


			var db1 = new NorthwindLib.Models.NorthwindDbContext();
			Console.WriteLine(db1.Shippers.First().CompanyName);

			var db2 = new ToursDbContext();

			Console.WriteLine(db2.TravelTips.First().Headline);

			var db3 = new BigStarLib.Models.BigStarDbContext();


			Console.WriteLine(db3.Aliens.First().Planet);
		}
	}
}
