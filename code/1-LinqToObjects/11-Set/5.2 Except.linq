<Query Kind="Statements" />

// Except: returns members of the first set that don't appear in the second set.

// List of all books in the library
var allBooks = new List<string>
{
		"Animal book",
		"Bagel book",
		"Cascade book",
		"Doorknob book",
		"E-bike book"
};

// List of books that are currently checked out
var checkedOutBooks = new List<string>
{
		"Bagel book",
		"Cascade book"
};

// Find the books that are still available in the library
var availableBooks = allBooks.Except(checkedOutBooks).ToList();


availableBooks.Dump("Books that are still available");
		