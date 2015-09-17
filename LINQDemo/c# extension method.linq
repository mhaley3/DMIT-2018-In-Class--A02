<Query Kind="Program" />

//c# primer on extension methods
void Main()
{
	string name = "Mason";
	string message = name.Sleepy();
	message.Dump();
	message = name.Sleepy(3);
	message.Dump();
}

// Define other methods and classes here
public static class StringExtensions
{
 public static string Sleepy(this string text)
 {
 	return text + " -Yawn?";
 }
 
 public static string Sleepy(this string text, int count)
 {
 	string tired = "Yawn";
	while (count > 0)
	{
		text = text + " - " + tired;
		count--;
	}
	
	return text + "! Yawn?";
  }
}