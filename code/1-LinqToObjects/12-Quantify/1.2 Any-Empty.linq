<Query Kind="Statements" />

 // Documentation states that .Any() is more effienct
 // That was true in older versions of .NET
 // Not so much in newer.
 // Count can determine if the sequence has a .Count  or .Length property
 
 // Not really an issue, differences are measured 
 // in nanoseconds
	// Create a large list of integers
	var numbers = Enumerable.Range(1, 10-000-000).ToList();

	int iterations = 100;
	long anyTotalTime = 0;
	long countTotalTime = 0;

	for (int i = 0; i < iterations; i++) {
		// Benchmark .Any()
		var stopwatch = Stopwatch.StartNew();
		bool hasAny = numbers.Any();
		stopwatch.Stop();
		anyTotalTime += stopwatch.ElapsedTicks;

		// Benchmark .Count() > 0
		stopwatch.Restart();
		bool hasCount = numbers.Count() > 0;
		stopwatch.Stop();
		countTotalTime += stopwatch.ElapsedTicks;
}
var averageAny = anyTotalTime / (double)iterations;
var averageCount = countTotalTime / (double)iterations;
Console.WriteLine($".Any() average time: {averageAny} ticks");
Console.WriteLine($".Count() > 0 average time: {averageCount} ticks");
Console.WriteLine($"Any() is {(averageCount / averageAny):F2} times faster.");