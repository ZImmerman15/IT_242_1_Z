using System;
using System.Collections.Generic;

namespace Chapter_5
{
	class Program
	{
		private static object word;
		private static IEnumerable<KeyValuePair<int, string>> movie;

		public static void Main() 
		{

			//Dictionary's are collections of a key/value pairs - just strongly typed. They can be of any type(int, string, bool, custom, etc).

			//////////////////////////////////////
			////How to make a dictionary in C#///
			////////////////////////////////////
			//makes a dictionary named 'toysSold' and adds key value pairs at the sane time, you can also make an empty dictionary and use nameOfDictionary.Add(Key, Value)
			Dictionary<string, int> studentAndGrades = new Dictionary<string, int>() {
				{ "Seth", 100 },
				{ "Gabe", 95 },
				{ "Pete", 90 },
				{ "Dave", 100 },
				{ "Levi", 85 }
			};
			//////////////////////////////////////////////////////////////////////////////////////////
			////how to use .Add(Key, Value) to add KeyValuePairs to the dictionary named "toysSold"///
			//////////////////////////////////////////////////////////////////////////////////////////
			//  "GI Joe" = Key   and   430 = Value || together they make a KeyValuePair
			studentAndGrades.Add("John", 100);
			//access and print this newly added Value(430) to the console by using the key of "GI Joe"
			


			////////////////////////////////////////////////////////////////////////
			////How to loop over the dictionary and print each students grade/////
			///////////////////////////////////////////////////////////////////////
			Console.WriteLine("****studentAndGrades****");//title of list you are about to print
			foreach (KeyValuePair<string, int> student in studentAndGrades)
			{
				Console.WriteLine($"{student.Key} grade {student.Value}");
			}

			//now lets make anither Dictionary that contains your top 5 video games, rank 1-5 would be of type 'int', and the name of the game would be type 'string'		
			////////////////////////////////////////////
			////How to make an empty dictionary in C#///
			////////////////////////////////////////////
			Dictionary<int, string> Movie = new Dictionary<int, string>();

			//now we have an empty dictionary called 'top5VideoGames, lets add some games with .Add() instead of using {key, value} after creating te Dictionary like the first dictionary we created      
			Movie.Add(1, "Hannible");
			Movie.Add(2, "Diablo");
			Movie.Add(3, "Avengers");
			Movie.Add(4, "Kids");
			Movie.Add(5, "Tank");

			//Now lets loop over the dictionary and print each key value pair to the Console
			//First lets print a title to the console
			Console.WriteLine("****Movie****");
			//loop over Dictionary and print each one
			foreach (KeyValuePair<int, string> title in Movie)
			{
				Console.WriteLine(title.Key + " " + title.Value);
			}
		}
	}
}