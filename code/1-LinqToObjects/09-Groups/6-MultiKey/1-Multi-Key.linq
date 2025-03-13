<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\CardLib\CardLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\CardLib\CardLib.dll</Reference>
</Query>

var products = new[]
{
		new { ProduceName = "Pear", Category = "Fruit", Farm = "The Veggie Patch" },
		new { ProduceName = "Cabbage", Category = "Vegetable", Farm = "Green Acres" },
		new { ProduceName = "Apple", Category = "Fruit", Farm = "Green Acres" },
		new { ProduceName = "Lemon", Category = "Fruit", Farm = "Citrus Hills" },
		new { ProduceName = "Lime", Category = "Fruit", Farm = "Citrus Hills" },
		new { ProduceName = "Pomelo", Category = "Fruit", Farm = "Citrus Hills" },
		new { ProduceName = "Kumquat", Category = "Fruit", Farm = "Citrus Hills" },
		new { ProduceName = "Carrot", Category = "Vegetable", Farm = "The Veggie Patch" },
		new { ProduceName = "Broccoli", Category = "Vegetable", Farm = "The Veggie Patch" },
		new { ProduceName = "Broccoli", Category = "Vegetable", Farm = "Green Acres" },
		new { ProduceName = "Onion", Category = "Vegetable", Farm = "Green Acres" }
};


var groupedByColorFamily = products.GroupBy(keySelector: p => new {  p.Farm,p.Category },
													elementSelector: y => new { y.ProduceName },
													resultSelector: (key, value) => new { ComboKey = key, Produce = value });
								
								groupedByColorFamily.OrderBy(group =>group.ComboKey.Farm ).Dump();