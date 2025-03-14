<Query Kind="Program" />

void Main()
{
	//Suppose you have two lists of employees: 
	// one containing employees currently working in the company 
	// and another containing employees who have completed a specific training. 
	// You want to find the employees who are both currently working 
	// and have completed the training.
	// List of currently working employees
	var workingEmployees = new List<Employee>
	{
		new Employee { Id = 1, Name = "Aisha" },
		new Employee { Id = 2, Name = "Carlos" },
		new Employee { Id = 3, Name = "Leonard" },
		new Employee { Id = 4, Name = "Fatima" }
};

	// List of employees who have completed training
	var trainedEmployees = new List<Employee>
	{
		new Employee { Id = 2, Name = "Carlos" },
		new Employee { Id = 4, Name = "Fatima" },
		new Employee { Id = 5, Name = "Hiroshi" }
};

	// Select IDs from both lists in query syntax
	var workingIds = from e in workingEmployees
									 select e.Id;

	var trainedIds = from e in trainedEmployees
									 select e.Id;

	// Intersect the IDs using method syntax
	var intersectedIds = workingIds.Intersect(trainedIds);

	// Find the employees who are both working and have completed the training
	var qualifiedEmployees = from id in intersectedIds
													 select workingEmployees.First(e => e.Id == id);

	// Convert to list
	var result = qualifiedEmployees.ToList();
	result.Dump();

}
// Define Employee class
public class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
}


