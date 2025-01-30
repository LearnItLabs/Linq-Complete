<Query Kind="Program" />

void Main()
{
	// deferred execution may cause
	// unexpected recursion and slowness
	
	
	int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
	
	var q = from n in numbers
						where FilterNumbers(n)
						select n;
	
	// the FilterNumber method is called 
	// nines times during the query execution
	// one for each number as needed by the where clause

	OutputResults(q);
	
	var q2 = from n in numbers
						orderby OrderNumbers(n)
						where FilterNumbers(n)
						select n;


	// both OrderNumbers and FilterNumbers are called			

	OutputResults(q2);
	var q3 = from n in numbers
					 where FilterNumbers(n)
					 orderby OrderNumbers(n)
					 select n;
	
	// both OrderNumbers and FilterNumbers are called	
	// this time in opposite order
	// note that is results in 6 less method calls
	OutputResults(q3);
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

public void OutputResults(object output)
{
	Console.WriteLine("====================================");
	numberOfCalls = 0;
	output.Dump("Run");
	numberOfCalls.Dump("number of calls");
}