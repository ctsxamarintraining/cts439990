using System;

namespace ExceptionsTwo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			double squareRootValue;
			int Number=0;
			try
			{
				Console.WriteLine("Enter a Number");
				Number= Convert.ToInt32 (Console.ReadLine());
				squareRootValue=Math.Sqrt(Number);

				if(Number<0)
					throw new ApplicationException("Number must be positive and non zero");
				Console.WriteLine("Square root of {0} is: {1}", Number, squareRootValue);

			}
			catch(FormatException fe) 
			{
				Console.WriteLine (fe.Message);
			}
			catch(Exception e) 
			{
					Console.WriteLine (e.Message);
			}
			finally
			{
				Console.WriteLine ("GoodBye");
			}
		}


	}
}
