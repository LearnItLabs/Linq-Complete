<Query Kind="Program">
  <Reference>C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// SelectMany flattens a one-to-many relationship,
// or in other words, it ungroups nested sequences into a single sequence.
void Main()
{
	HistoryCalendar cal;
	var calendars = new List<HistoryCalendar>();

	cal = new HistoryCalendar();
	cal.Decade = "Seventies";
	cal.Years = Enumerable.Range(1970, 10).ToList();
	calendars.Add(cal);

	cal = new HistoryCalendar();
	cal.Decade = "Eighties";
	cal.Years = Enumerable.Range(1980, 10).ToList();
	calendars.Add(cal);
	var q = from calendar in calendars
					select calendar;

	q.Dump();
	// SelectMany extracts the Years list from each HistoryCalendar instance  
	// and flattens them into a single combined list.
	var q2 = calendars.SelectMany(m => m.Years);
	q2.Dump();
}

// Define other methods and classes here
public class HistoryCalendar
{

	public string Decade { get; set; }
	public List<int> Years { get; set; }
}