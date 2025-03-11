<Query Kind="Statements" />

// DefaultIfEmpty is a LINQ method that ensures a sequence is not empty. 
// If the exiting sequence is empty, it returns a new sequence 
// containing a default value or a specified value. 

// * Prevents empty collections in cases where at least one value is required.
// * Maintains existing data—only applies when the sequence is truly empty.
var numbersSource = new List<int> { 1, 3 };

IEnumerable<int> numbersChecked ;
numbersChecked= Enumerable.DefaultIfEmpty<int>(numbersSource);
numbersChecked.Dump("Has numbers");
numbersSource.Add(5);
numbersSource.RemoveAll(n => n > 0);
;
numbersSource.Dump("Empty sequence.");
// When the source enumerable has no entries, 
// return an enumerable with a single value; the default value.
numbersChecked= Enumerable.DefaultIfEmpty<int>(numbersSource);

numbersChecked.Dump("Default value added to sequence.");

numbersChecked = Enumerable.DefaultIfEmpty<int>(numbersSource,25); // use another value

numbersChecked.Dump("My value added to sequence.");

