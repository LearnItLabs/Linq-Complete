<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// LINQPad supports multiple lines
// with the Statement editor


int x = 12;
bool isBig = x > 1000;
string isBigString = isBig ? "Big number" : "Small number";

// you decide how to output to the results window!

Console.WriteLine(isBigString);