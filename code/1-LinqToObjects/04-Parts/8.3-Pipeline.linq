<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// A query consists of a source (sequence) and
// and at least one query operator.

// All query operators are implemented as extension methods  
// and are defined in the Enumerable class.

var a = Assembly.Load("System.Linq");


var q2 = from method in typeof(System.Linq.Enumerable).GetMethods()
		 orderby method.Name
		 where method.ReturnType.IsGenericType
		 && method.ReturnType.GetGenericTypeDefinition() == typeof(IEnumerable<>)
		 |  method.ReturnType.GetGenericTypeDefinition() == typeof(IOrderedEnumerable<>)
		 select new { Name = method.Name, ReturnType = method.ReturnType.Name.Replace("`1", "<T> ") };
q2.Dump("Enumerable methods that return IEnumerable or IOrderedEnumerable");


