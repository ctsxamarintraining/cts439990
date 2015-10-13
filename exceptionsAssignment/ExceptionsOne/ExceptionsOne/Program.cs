using System;

namespace ExceptionsOne
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try
			{
				int [] array=new int[10];
				int k=0;
				for(int j=0;j<=k;j++)
				{
					Console.WriteLine("enter a number");
					int i=Convert.ToInt32(Console.ReadLine());
					array[k]=i;
					Console.WriteLine("Elements in the array are:");
					for(int l=0;l<=k;l++)
					{
						Console.Write("{0},",array[l]);
					}
					Console.WriteLine();
					k++;
				}
			}

			catch(IndexOutOfRangeException iex) 
			{
				Console.WriteLine (iex.Message);
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
				Console.WriteLine ("Finally Block Executed");
			}
		}
	}
}
