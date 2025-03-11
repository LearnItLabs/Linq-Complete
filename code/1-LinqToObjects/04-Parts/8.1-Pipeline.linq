<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// Pipelining in LINQ relies on a few key concepts
// ✅ Extension methods: provide the mechanism to chain one method 
// 		output to another methods input.
// ✅ The input and output types need to be
//    IEnumerable<T> or IOrderedEnumerable<T> 

	var a = Assembly.Load("System.Linq");

	var q1 = from method in typeof(System.Linq.Enumerable).GetMethods()
			 orderby method.Name
			 
				select new { Name = method.Name, ReturnType = method.ReturnType.Name.Replace("`1", "<T> " )};
	q1.Dump("All Enumerable method overloads and their return type.");



