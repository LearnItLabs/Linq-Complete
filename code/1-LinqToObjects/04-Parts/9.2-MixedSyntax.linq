<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgundy","Purple",
		  "White", "Black", "Blue" ,"Bronze", "Gray"};

var gColors = colors.Where(c => c.StartsWith("G"));

var q2 = from color in gColors
				 orderby color
				 select color;


q2.Dump("Where method as source for query expression.");

// use Count on query expression

var q3 = (from color in colors
		  		where color.StartsWith("G")
		  		select color).Count();
q3.Dump("Use .Count in query expression.");