using System;
using System.Collections.Generic;

namespace Day6Four
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<string> AList = new List<string>();
			AList.Add ("A");
			Console.WriteLine ("Elements in list are");
			foreach (string ele in AList)
				Console.WriteLine (ele);
			AList.AddRange (new List<string> (){ "B", "C", "D" });
			Console.WriteLine ("Elements in list are");
			foreach (string ele in AList)
				Console.WriteLine (ele);
			AList.Remove ("B");
			Console.WriteLine ("Element deleted is B");
			Console.WriteLine ("Elements in list are");
			foreach (string ele in AList)
				Console.WriteLine (ele);
			AList.Insert (1,"F");
			Console.WriteLine ("Elements in list are");
			foreach (string ele in AList)
				Console.WriteLine (ele);
			AList.Clear ();
			Console.WriteLine ("list is cleared");



			Dictionary<int,string> ADictionary = new Dictionary<int, string> (){{1,"Divya"},{2,"sravan"}};
			ADictionary.Add (3, "madhu");
			Console.WriteLine ("Keys in Dictionary are");
			foreach (int ele in ADictionary.Keys)
				Console.WriteLine (ele);
			Console.WriteLine ("Values in Dictionary are");
			foreach (string ele in ADictionary.Values)
				Console.WriteLine (ele);
			ADictionary.ContainsValue ("madhu");
			ADictionary.Remove (3);
			Console.WriteLine ("Keys in Dictionary are");
			foreach (int ele in ADictionary.Keys)
				Console.WriteLine (ele);
			Console.WriteLine ("Values in Dictionary are");
			foreach (string ele in ADictionary.Values)
				Console.WriteLine (ele);
			ADictionary.Clear ();
		}
	}
}
