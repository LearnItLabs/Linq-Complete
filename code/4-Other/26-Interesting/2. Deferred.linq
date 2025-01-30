<Query Kind="Program" />

void Main()
{
	int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
	
	var filtered = from n in numbers
						where FilterNumbers(n)
						select n;
	// add another query that works with first query.
	var q2 = from n in filtered
					 select n;
					 
	// the FilterNumber method is called 
	// nines times during the query execution
	// because the filter query is run, while executing the q2
   	OutputResults(q2);

	
	
	var cartesian  =  from a in filtered 
										from b in filtered
					 					select new {a=a, b=b};
										

	// the FilterNumber method is called 
	// 36 times during the query execution
	// this is due the the deferred execution.
	// What many devs misunderstand is that the results are NOT 
	// filtered by the first (from a in filterd) before running the second
 	OutputResults(cartesian);
	
					 
}

public void OutputResults(object output)
{
	Console.WriteLine("====================================");
	numberOfCalls = 0;
	output.Dump("Run");
	numberOfCalls.Dump("number of calls");
}

// Define other methods and classes here
int numberOfCalls = 0;
public bool FilterNumbers(int candidate)
{ 
	numberOfCalls +=1;
	Console.WriteLine("Filtering: " + candidate.ToString());
	return candidate % 3 == 0;
}

public int OrderNumbers(int candidate)
{
	numberOfCalls +=1;
	Console.WriteLine("Ordering: " + candidate.ToString());
	return 10 - candidate ;
}