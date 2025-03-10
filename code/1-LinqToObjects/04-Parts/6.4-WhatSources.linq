<Query Kind="Statements" />

// This might seem odd,
// but we can query the contents of a string.

	// 	string
	var letters = "ABC DEF GHI";

	var q1 = from s in letters
			     select s;

	q1.Dump();

	var sentence = "Billy, Bhrama and Brianna, went for a bike ride.";

	var q2 = from s in sentence
					 where s != ' '
					 orderby s
					 select s;

	q2.Dump("Remove spaces and orderby.");

	var q3 = from c in sentence
					 where c == 'B'
					 select c;

	q3.Count().Dump("Count of 'B'");
	
	var newString = String.Join('-',q2.Select(q => q).ToArray());
	newString.Dump();