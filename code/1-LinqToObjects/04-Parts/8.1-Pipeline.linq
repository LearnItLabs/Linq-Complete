<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// Pipelining in LINQ relies on a few key concepts
// ✅ Extension methods: provide a elegant way to connect method calls together 
// 		in a single expression.
// ✅ Extension methods: Enable chaining of one method's output
// 		to another methods input.
// ✅ LINQ Enumerable: The methods input and output types must be
//    IEnumerable<T> or IOrderedEnumerable<T>.

// The pipeline typically start with a source that implements IEnumerable<T> 
// That source it passed to one or more query operators.
// Each operator takes a IEnumerable<T> or IOrderedEnumerable<T> parameter
// and returns a IEnumerable<T> or IOrderedEnumerable<T>.
// The pipeline is processed when we iterate over the query

// 	Query operators can either continue the pipeline 
//  by returning IEnumerable<T> or IOrderedEnumerable<T>
// (e.g. OrderBy, Where) 
//  or terminate it by return something else (Sum, Average, Count)!

var a = Assembly.Load("System.Linq");

var q1 = from method in typeof(System.Linq.Enumerable).GetMethods()
				 let cleanData = new { MethodName = method.Name, ReturnType = method.ReturnType.Name.Replace("`1", "<T> ") }

				 group method by cleanData.ReturnType
					into methodGroup
				 orderby methodGroup.Key
				 select new { Name = methodGroup.Key, Methods = methodGroup.Select(m => m.Name) };

q1.Dump("All Enumerable method overloads and their return type.");



// old


