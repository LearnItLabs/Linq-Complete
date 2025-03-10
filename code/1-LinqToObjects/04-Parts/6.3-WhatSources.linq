<Query Kind="Statements" />

// more types that implement IEnumerable

var myBools = new Stack<bool>();
myBools.Push(true);
myBools.Push(false);
myBools.Push(true);
myBools.Push(false);

	var q4 = from s in myBools
				orderby s
			 select s;

	q4.Dump();

	var dict = new Dictionary<int, string>();
	dict.Add(4, "****");
	dict.Add(2, "EE");
	dict.Add(8, "!!!!!!!!");
	dict.Add(9, "%%%%%%%%%");

	var q5 = from d in dict
			 		select d;

	q5.Dump();
	q5.Where(c => c.Key < 5).Dump();