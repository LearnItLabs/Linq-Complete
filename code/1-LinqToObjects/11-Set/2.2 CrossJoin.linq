<Query Kind="Statements" />

// When performing combinatorial analysis, 
// you often need to generate all possible pairs or combinations of items. 
// For example, generating all possible pairs of students for a project 
// or all possible menu combinations in a restaurant.

// List of colors
var colors = new List<string> { "Scarlet", "Olive", "Azure" };

// List of sizes
var sizes = new List<string> { "Small", "Medium", "Large" };

// Generate all possible combinations of colors and sizes
var combinations = from color in colors
									 from size in sizes
									 select new { Color = color, Size = size, Desc=$"Color: {color}, Size: {size}"};


combinations.Dump();