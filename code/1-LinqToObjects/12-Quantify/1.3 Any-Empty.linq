<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// compare speed



int iterations = 40;
long anyTotalTime = 0;
long countTotalTime = 0;
	
for (int i = 0; i < iterations; i++)
{
	var linkedList = new LinkedList<int>(Enumerable.Range(1, 200000));

	// Benchmark .Any()
	var stopwatch = Stopwatch.StartNew();
	bool hasAny = linkedList.Any();
	stopwatch.Stop();
	anyTotalTime += stopwatch.ElapsedTicks;
 

}
for (int i = 0; i < iterations; i++)
{
	var linkedList = new LinkedList<int>(Enumerable.Range(1, 200000));
	// Benchmark .Count() > 0
	var stopwatch = Stopwatch.StartNew();
	bool hasCount = linkedList.Count() > 0;

	stopwatch.Stop();
	countTotalTime += stopwatch.ElapsedTicks;
}

var averageAny = anyTotalTime / (double)iterations;
var averageCount = countTotalTime / (double)iterations;
Console.WriteLine($".Any() average time: {averageAny} ticks");
Console.WriteLine($".Count() > 0 average time: {averageCount} ticks");
Console.WriteLine($"Any() is {(averageCount / averageAny):F2} times faster.");

