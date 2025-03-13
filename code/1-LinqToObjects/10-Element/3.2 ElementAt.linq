<Query Kind="Statements" />

// Not all collections support indexers (collection[index]). 
// Here are some common collections that don't have an indexer:
// IEnumerable<T> , LinkedList<T>
// Queue<T> and Stack<T>
// HashSet<T>, Dictionary<TKey, TValue>
// SortedSet<T>
var colors = new Dictionary<string, string>
{
		{ "Amber", "FF440033" },
		{ "Teal", "FF237865" },
		{ "Coral", "FF55EEC8" }
};

// dict[0]; // Error: No indexer for positions
string value = colors["Teal"]; // Uses key lookup

value.Dump("Dictionary value by key");

colors.ElementAt(2).Dump ("ElementAt 2 (key-value pair)");

colors.ElementAtOrDefault(31).Dump ("ElementAt 31");