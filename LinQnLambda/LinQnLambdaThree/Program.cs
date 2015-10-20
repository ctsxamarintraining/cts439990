using System;
using System.Globalization;

namespace LinQnLambdaThree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string str=@"this is the string to be converted";
			string convertedString=str.convertMethod();
			Console.WriteLine (convertedString);
		}



	}
	public static class extensionClass
	{
		public static string convertMethod(this string s)
		{
			TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
			return ti.ToTitleCase (s);
		}
	}

}
