using System;

namespace day5MorningTwo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Nullable<int> i = null;
			Console.WriteLine ("i has a value?{0}",i.HasValue);
			i = 30;
			Console.WriteLine ("i has a value?{0}",i.HasValue);
			Console.WriteLine ("value of i is{0}:",i.Value);
		}
	}
}
