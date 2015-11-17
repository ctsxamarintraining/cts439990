using System;
using System.Linq;

namespace LinQnLambdaTwo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] array = new int[]{ 21, 6, 7, 42, 10 };
			var linQresult = from element in array
					where element%7==0 && element%3==0
			           select element;
			foreach (var x in linQresult)
			{
				Console.WriteLine (x);
			}
			var lambdaResult = array.Where (x => x % 7 == 0 && x % 3 == 0).Select(x=>x);
			foreach (var y in lambdaResult)
			{
				Console.WriteLine (y);
			}
		}
	}
}
