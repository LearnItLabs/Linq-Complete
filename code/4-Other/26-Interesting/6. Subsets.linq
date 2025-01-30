<Query Kind="Statements" />

var colors = new List<string>
		 { "Red", "Blue", "Green" };

// we can generate all subsets of list as follows
var subsets = from m in Enumerable.Range(0, 1 << colors.Count)
							select
									from i in Enumerable.Range(0, colors.Count)
									where (m & (1 << i)) != 0
									select colors[i];

foreach (var subset in subsets) {
	Console.WriteLine(string.Join(" : ", subset));
}

