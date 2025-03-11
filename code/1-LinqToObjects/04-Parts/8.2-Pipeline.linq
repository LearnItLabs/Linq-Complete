<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// Pipeline candidates
// are methods that return IEnumerable or IOrderedEnumerable

// The key distinction is whether the method continues 
// the LINQ query pipeline or terminates it.
// .OrderBy continues the pipeline
// .Count would terminate the pipeline



var a = Assembly.Load("System.Linq");


var q1 = from method in typeof(System.Linq.Enumerable).GetMethods()
				 orderby method.Name
				 where method.ReturnType.IsGenericType
				 && method.ReturnType.GetGenericTypeDefinition() == typeof(IEnumerable<>)
				 | method.ReturnType.GetGenericTypeDefinition() == typeof(IOrderedEnumerable<>)
				 select new { Name = method.Name, ReturnType = method.ReturnType.Name.Replace("`1", "<T> ") };
q1.Dump("Enumerable methods that return IEnumerable or IOrderedEnumerable");

var q2 = from method in typeof(System.Linq.Enumerable).GetMethods()
				 let returnType = method.ReturnType
				 where !returnType.IsGenericType ||
							 (returnType.GetGenericTypeDefinition() != typeof(IEnumerable<>) &&
								returnType.GetGenericTypeDefinition() != typeof(IOrderedEnumerable<>))
				 orderby method.Name
				 select new { Name = method.Name, ReturnType = method.ReturnType.Name.Replace("`1", "<T> ") };


q2.Dump("Enumerable methods that terminate a pipeline or perform some other function.");
