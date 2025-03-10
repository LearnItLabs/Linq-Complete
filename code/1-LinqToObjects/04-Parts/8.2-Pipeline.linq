<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// Pipeline candidates
// are methods that return IEnumerable or IOrderedEnumerable

// The key distinction is whether the method continues the LINQ query pipeline or terminates it.
// .OrderBy continues the pipeline
// .Count would terminate the pipeline
var a = Assembly.Load("System.Linq");

var q1 = from method in typeof(System.Linq.Enumerable).GetMethods()
				 let cleanData = new {MethodName = method.Name, ReturnType = method.ReturnType.Name.Replace("`1", "<T> ")}
				
					group method by cleanData.ReturnType
					into methodGroup 
					orderby methodGroup.Key
				 select new { Name = methodGroup.Key, Methods = methodGroup.Select(m => m.Name) };

q1.Dump("All Enumerable method overloads and their return type.");




