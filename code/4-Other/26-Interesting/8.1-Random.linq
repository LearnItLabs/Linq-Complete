<Query Kind="Statements" />

	var colors = new List<string> 
		{ "Green", "BlackAsNight", "Yellow",  "Red", "Orange", "Purple", 
		   "White", "Black", "Blue" ,"BrownBarrymore"};
	colors.Dump();
	Random r = new Random();
	
	var output = colors.OrderBy(c=>r.NextDouble());
	
	output.Dump();