<Query Kind="Program" />

void Main()
{
	var students = Names();
	//students.Dump();
	var lastInitial_s = from person in students
						where person.Contains(" S")
						select person;
	
	lastInitial_s.Dump("People whose last name starts with 'S'");
}

// Define other methods and classes here
public List<string> Names()
{
	List<string> data = new List<string>();
	data.Add("Bob Saunders");
	data.Add("Mason Haley");
	data.Add("Don Welch");
	data.Add("Jill Saunders");
	data.Add("Bill Smith");
	
	return data;
	
}