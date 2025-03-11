<Query Kind="Statements" />

// DefaultIfEmpty is a  LINQ method that ensures a sequence is not empty. 
// If the exiting sequence is empty, it returns a new sequence 
// containing a default value or a specified value. 

// * Prevents empty collections in cases where at least one value is required.
// * Maintains existing data—only applies when the sequence is truly empty.

var colorsSource = new List<string> { "Red", "Orange" };

IEnumerable<string> colorsChecked ;
colorsChecked= Enumerable.DefaultIfEmpty<string>(colorsSource);
colorsChecked.Dump();
colorsSource.Remove("Red");

colorsSource.Remove("Orange");


// When the source enumerable has no entries, 
// return an enumerable with a single value; the default value.
colorsChecked= Enumerable.DefaultIfEmpty<string>(colorsSource);

colorsChecked.Dump();

colorsChecked = Enumerable.DefaultIfEmpty<string>(colorsSource,"Transparent"); // use another value

colorsChecked.Dump();

