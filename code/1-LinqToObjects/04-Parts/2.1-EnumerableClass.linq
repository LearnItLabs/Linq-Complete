<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// A query consists of a source (sequence) and
// and at least one query operator.

// All query operators are implemented as extension methods  
// and are defined in the Enumerable class.

var a = Assembly.Load("System.Linq");

MethodInfo[] theMethods = typeof(System.Linq.Enumerable).GetMethods();

var theOperators = from method in theMethods
										orderby method.Name
										group method by method.Name into g
										select new { Name = g.Key, Overloads = g.Count() };

theOperators.Dump();