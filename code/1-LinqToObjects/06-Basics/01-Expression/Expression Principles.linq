<Query Kind="Expression" />

// Let's review some principles
// LINQ query expressions can be categorized into three areas

// 1. Sequence to Same Sequence Type:
//    Takes a sequence, returns a new sequence containing the same element type.
// 		The elements can be sorted, grouped, or filtered, but they remain the same type.

//    Doubles to Doubles, Strings to Strings, Products to Products, etc.


// 2. Sequence to Different Sequence Type:
//    Takes a sequence and returns a new sequence containing a different type of element. 
//  	This involves transforming each object in the original sequence into a different type.

//    Integers to Decimals, Products to Strings

// 3. Sequence to Single Value:
//		Takes a sequence, returns a single value by reducing the list 
//		of data to an aggregate value.
//    AKA (fold, reduce, aggregate, accumulate, etc.)

//    Min, Max, Sum, Aggregate, Count