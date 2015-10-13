using System;
using System.IO;

namespace ExceptionsThree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string path = "";

//			if (!File.Exists(path))
//			{
//		
//				string createText = "Hello and Welcome" ;
////				File.WriteAllText(path, createText);
//			}
				
//			string appendText = "This is extra text";
//			File.AppendAllText(path, appendText);
			try{
			string readText = File.ReadAllText(path);
			Console.WriteLine(readText);
			}
			catch(ArgumentNullException ane)
			{
				Console.WriteLine ("Path cannot be null");
				Console.WriteLine (ane.Message);
			}
			catch(ArgumentException ae)
			{
				Console.WriteLine ("Enter a Path");
				Console.WriteLine (ae.Message);
			}
			catch(PathTooLongException ptle)
			{
				Console.WriteLine ("Path is too long");
				Console.WriteLine (ptle.Message);
			}
			catch(DirectoryNotFoundException dnfe) 
			{
				Console.WriteLine ("Directory Not Found");
				Console.WriteLine (dnfe.Message);
			}
			catch(FileNotFoundException fnfe) 
			{
				Console.WriteLine ("Could not find the file at the given path");
				Console.WriteLine (fnfe.Message);
			}
			catch(IOException ioe) 
			{
				Console.WriteLine (ioe.Message);
			}

			catch(UnauthorizedAccessException uaae)
			{
				Console.WriteLine (uaae.Message);
			}

			catch(NotSupportedException nse) 
			{
				Console.WriteLine ("path is in an invalid format");
				Console.WriteLine (nse.Message);
			}
			finally 
			{
				Console.WriteLine ("reached finally block");
			}
		}
	}
}
