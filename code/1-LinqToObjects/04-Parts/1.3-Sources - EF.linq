<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Data.Entity.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
  <NuGetReference>Microsoft.EntityFrameworkCore</NuGetReference>
</Query>

//  IQueryable 
//  is an interface designed Queryable providers
//  i.e. remote data sources, like database
// 	allows for more sophicated query expressions and disparate data sources
// 
//  Learn about it when you want to use LINQ to Entities, LINQ to SQL (obsolete) etc.
//var a = Assembly.Load("System.Data.Entity"); // .NET Framework
var a = Assembly.Load("Microsoft.EntityFrameworkCore"); // .NET
var q = from t in a.GetExportedTypes()
				from i in t.GetInterfaces()
				where i.IsGenericType && t.IsClass && i.GetGenericTypeDefinition() == typeof(IQueryable<>)
				orderby t.Name
				select t.Name;

q.Dump();