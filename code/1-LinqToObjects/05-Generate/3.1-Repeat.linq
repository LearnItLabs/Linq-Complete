<Query Kind="Statements" />

 // Enumerable.Repeat is a functional and concise alternative to loops.
 // Avoids mutable state and aligns with LINQ’s declarative style.
 // Works with any data type, including numbers, strings, and objects.

// The Imperative (Statement-Based) Approach
List<int> manyThrees = new List<int>();
for (int i = 0; i < 120; i++)
{
	manyThrees.Add(3);
}

manyThrees.Dump("Many Threes");

// The Functional Approach:
// A more concise and functional way to achieve the same resul

var manyFives = Enumerable.Repeat<int>(5, 200);

manyFives.Count().Dump("Count");
manyFives.Dump("Many Fives");