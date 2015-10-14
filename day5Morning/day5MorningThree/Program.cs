using System;

namespace day5MorningThree
{
	class MainClass
	{
		delegate void Mydelegate(int x);

		public static void EnteredNumber(int n)
		{
			Console.WriteLine ("Entered Number is {0}",n);
		}

		public static void Main (string[] args)
		{
			
			Mydelegate mydelegate=delegate(int num){
				Console.WriteLine("this is an anonymous delegate method {0}",num);
			};
			mydelegate(9);

			mydelegate = new Mydelegate (EnteredNumber);
			mydelegate(6);

		}
	}
}
