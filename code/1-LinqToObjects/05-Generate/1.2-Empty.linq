<Query Kind="Program" />

void Main()
{
	var fullOfData = new List<int> {2,4,6,8};
	ProcessData(fullOfData);
	
	var emptyOfData = Enumerable.Empty<int>();
	ProcessData(emptyOfData);
	
}

// You can define other methods, fields, classes and namespaces here


void ProcessData(IEnumerable<int> data)
{
	// 
	if (!data.Any()) {
		"The sequence is empty.".Dump();
	}
	else {
		Console.WriteLine("Processing data...");
		data.Dump();
	}
}

				