<Query Kind="Statements" />


var colors = new List<string> {"purple", "orange", "red", "green", "yellow"};
colors.Dump();
colors.DumpTell(); // adds a description header 

var colorValues = new Dictionary<string, string>();

colorValues.Add("purple" , "553311");
colorValues.Add ("yellow","FF63DD");

// no header
colorValues.Dump();
// customize the results header
colorValues.Dump("Keys and values");