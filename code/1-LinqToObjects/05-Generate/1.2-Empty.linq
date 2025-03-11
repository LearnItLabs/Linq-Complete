<Query Kind="Program" />

void Main()
{
	var validList = new List<int> {2,4,6,8};
	ProcessData(validList);
	
	var emptyList = Enumerable.Empty<int>().ToList();
	ProcessData(emptyList);
	
}

// You can define other methods, fields, classes and namespaces here


void ProcessData(IEnumerable<int> data)
{
	// we don't data to be null
	if (!data.Any()) {
		"The sequence is empty.".Dump();
	}
	else {
		Console.WriteLine("Processing data...");
		data.Dump();
	}
}

				