<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>



	var a = Assembly.Load("System.Linq");

	var q1 = from method in typeof(System.Linq.Enumerable).GetMethods()
			 orderby method.Name
			 
				select new { Name = method.Name, ReturnType = method.ReturnType.Name.Replace("`1", "<T> " )};
	q1.Dump("All Enumerable method overloads and their return type.");



