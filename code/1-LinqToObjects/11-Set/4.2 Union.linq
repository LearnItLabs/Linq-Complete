<Query Kind="Statements" />

// Union:  merge two sequences, remove all duplicates


// List of products in stores
var storeInventory1 = new List<string>
{
		"Laptop",
		"Mouse",
		"Keyboard",
		"Monitor"
};

// List of products in Warehouse 2
var storeInventory2 = new List<string>
{
		"Mouse",
		"Chair",
		"Desk",
		"Monitor"
};

// List of products in Warehouse 3
var storeInventory3 = new List<string>
{
		"Laptop",
		"Desk",
		"Printer",
		"Mouse"
};

// Combine all lists into one list of unique products
var allProducts = storeInventory1.Union(storeInventory2).Union(storeInventory3);
		

allProducts.Dump();
