<Query Kind="Statements" />

// LINQ to Objects works with types that implement IEnumerable<T>.
//
// Arrays receive special treatment from the CLR.
// They implement IEnumerable, but not IEnumerable<T> directly.

// But for any single-dimensional, zero-lower-bound array, 
// the CLR modifies it to: 
// - Inherit from Array. 
// - Implement IEnumerable<T>, ICollection<T>, and IList<T>.

// The implementation details aren't crucial
// what matters is that 
// arrays are fully queryable using LINQ.

Double[] array = new Double[] { 4.4, 2.2, 6.6 };

var q2 = from a in array
		 orderby a
		 select a;

q2.Dump();