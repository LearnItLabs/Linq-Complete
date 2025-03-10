<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
				 "White", "Black", "Blue" ,"Bronze" ,"Olive"};


var q = from x in colors
		where x.Length > 5
		orderby x
		select new {x, WordLength = x.Length} ;

q.Dump("Words longer than 5 characters.");