<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// A Query consists of a source (sequence) and
// and at least one Query Operator

// All the Query Operators are implemented as extension methods
// and are in the Enumerable class.

var a = Assembly.Load("System.Linq");

MethodInfo[] theMethods = typeof(System.Linq.Enumerable).GetMethods();

var theOperators = from method in theMethods
										orderby method.Name
										group method by method.Name into g
										select new { Name = g.Key, Overloads = g.Count() };

theOperators.Dump();