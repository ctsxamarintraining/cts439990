using System;
using System.IO;

namespace FilesOne
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string oldFilepath=@"C:\Users\Public\TestFolder\WriteText.txt";

			//Writing text to a new file
			string text = "A class is the most powerful data type in C#. Like a structure, " +
				"a class defines the data and behavior of the data type.";
			System.IO.File.WriteAllText(oldFilepath, text);


			//reading text from the path
			string readText = File.ReadAllText(oldFilepath);
			Console.WriteLine ("original Text is:{0}",readText);

			//Reversing the text
			char[] separators = new char[]{ '.' };
			string[] stringsArray = readText.Split (separators,StringSplitOptions.RemoveEmptyEntries);
			Array.Reverse (stringsArray);
			string sep = ".";
			string reversedString = string.Join (sep, stringsArray);
			Console.WriteLine ("reversed string is:{0}",reversedString);

			//writing the reversed text to a new file

			string newFilePath=@"C:\Users\Public\TestFolder\WriteText1.txt";
			System.IO.File.WriteAllText (newFilePath, reversedString);

		}
	}
}
