<Query Kind="Statements" />

// GetProcesses returns an array
// so we can query the Windows OS/
var q = from p in Process.GetProcesses ()
				let threads = p.Threads.Count
        where threads > 5 
        orderby threads descending
        select new {p.ProcessName, threads};
			
			
			
			q.Dump("Threads");