<Query Kind="Statements" />

{
	// Create a large list of integers
	var numbers = Enumerable.Range(1, 10000000).ToList();

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

	Console.WriteLine($".Any() average time: {anyTotalTime / (double)iterations} ticks");
	Console.WriteLine($".Count() > 0 average time: {countTotalTime / (double)iterations} ticks");

}