<Query Kind="Statements" />

string tempPath = Path.GetTempPath();

	DirectoryInfo dirInfo = new DirectoryInfo( tempPath );

		var bigFiles =	from  	f in dirInfo.GetFiles()
							where   f.Length > 10000
							orderby f.Length descending
							select  new {FileName = f.Name, 
													 Size=String.Format("{0:N0}",f.Length),
													 TimeStamp=f.LastWriteTime};
		bigFiles.Take(20).Dump();
