<Query Kind="Program">
  <Reference Relative="..\..\..\Data\Assemblies\CardLib\CardLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\CardLib\CardLib.dll</Reference>
</Query>

void Main()
{
	var products = new List<Produce>
{
		new Produce{ProduceName= "Pear", Category= "Fruit", Farm = "The Veggie Patch" },
		new Produce{ProduceName="Cabbage", Category= "Vegetable", Farm= "Green Acres" },
		new Produce{ ProduceName = "Apple", Category = "Fruit", Farm = "Green Acres" },
		new Produce{ ProduceName = "Lemon", Category = "Fruit", Farm = "Citrus Hills" },
		new Produce{ ProduceName = "Lime", Category = "Fruit", Farm = "Citrus Hills" },
		new Produce{ ProduceName = "Pomelo", Category = "Fruit", Farm = "Citrus Hills" },
		new Produce{ ProduceName = "Kumquat", Category = "Fruit", Farm = "Citrus Hills" },
		new Produce{ ProduceName = "Carrot", Category = "Vegetable", Farm = "The Veggie Patch" },
		new Produce{ ProduceName = "Broccoli", Category = "Vegetable", Farm = "The Veggie Patch" },
		new Produce{ ProduceName = "Broccoli", Category = "Vegetable", Farm = "Green Acres" },
		new Produce{ ProduceName = "Onion", Category = "Vegetable", Farm = "Green Acres" }
};


	var groupedByColorFamily = products.GroupBy(keySelector: p => new { p.Farm, p.Category },
														elementSelector: y => new { y.ProduceName },
														resultSelector: (key, value) => new { ComboKey = key, Produce = value });

	groupedByColorFamily.OrderBy(group => group.ComboKey.Farm).Dump();
}

// You can define other methods, fields, classes and namespaces here
public class Produce
{
	public string ProduceName { get; set; }
	public string Category { get; set; }
	public string Farm { get; set; }

}