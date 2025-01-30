<Query Kind="Statements" />

var q = from method in typeof(System.String).GetMethods()
						orderby method.Name
						group method by method.Name into g
						select new { Name = g.Key, Overloads = g.Count() };

	q.Dump("Enumerate methods");