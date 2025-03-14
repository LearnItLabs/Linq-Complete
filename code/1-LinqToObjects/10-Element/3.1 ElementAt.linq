<Query Kind="Statements" />

// ElementAt: Returns the element at a specified index in a sequence.

// ElementAtOrDefault: Returns the element at a specified index in a sequence or a default value if the index is out of range.


var numList = new List<int> { 0, 5, 10, 15, 20, 25, 30 };
int[] numArray = new[] { 2, 4, 6, 8 };

numList[2].Dump("indexed list");
numArray[2].Dump("indexed array");



numList.ElementAt(2).Dump("ElementAt 2");
numArray.ElementAt(2).Dump("ElementAt 2 ");

// numList[31].Dump(); //throws an exception
numList.ElementAtOrDefault(31).Dump("ElementAt 31");