<Query Kind="Statements" />

// LINQ to objects works on types
// that Implement IEnumerable<T>.
//
// Arrays receive special treatment from the CLR.
// Arrays implement IEnumerable, not IEnumerable<T>

// But for any single-dimensional, zero-lower-bound array, 
// the CLR modifies it to: 
// - Inherit from Array. 
// - Implement IEnumerable<T>, ICollection<T>, and IList<T>.

// The implementation details are not important however,
// because arrays are queryable.

Double[] array = new Double[] { 4.4, 2.2, 6.6 };

var q2 = from a in array
		 orderby a
		 select a;

q2.Dump();