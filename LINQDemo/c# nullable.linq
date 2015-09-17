<Query Kind="Program" />

void Main()
{
	int? totalCount = null;
	totalCount.Dump();
	
	if(totalCount.HasValue)
	{
		"It has a value".Dump(); // HasValue is false if there is no value
	}
	
	else
	{
		"It does not have a value - it is 'null'".Dump();
	}
	
	totalCount = 99;
	totalCount.Dump();
	
}

// Define other methods and classes here