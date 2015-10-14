using System;

namespace day5MorningFive
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			display DisplayObject = new display ();
			DisplayObject.displayNumber ();
			DisplayObject.displayWord ();
		}
		public partial class display
		{
			public void displayNumber()
			{
				int i = 10;
				Console.WriteLine ("The Number is {0}", i);
			}
		}
		public partial class display
		{
			public void displayWord()
			{
				string word = "Divya";
				Console.WriteLine ("word is {0}", word);
			}
		}
	}
}
