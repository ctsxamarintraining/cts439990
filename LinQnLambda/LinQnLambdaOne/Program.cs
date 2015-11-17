using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQnLambdaOne
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<person> iList = new List<person>(){
				new person{ firstName = "Divya", lastName = "Vuppala" },
				new person{ firstName = "sravan", lastName = "Varma" },
				new person{ firstName = "Vasundhara", lastName = "Kuchibhatla" },
				new person{ firstName = "madhu", lastName = "yadav" }
			};

			Console.WriteLine("Linq Operation results");
			var resultList1 = from element in iList orderby element.firstName descending
				select element;
			Console.WriteLine("Sorting by firstName--->");
			foreach (person x in resultList1) 
			{
				Console.WriteLine ("{0},{1}",x.firstName,x.lastName);
			}
			var resultList2 = from element in iList orderby element.lastName descending
				select element;
			Console.WriteLine("Sorting by lastName---->");
			foreach (person x in resultList2) 
			{
				Console.WriteLine ("{0},{1}",x.lastName,x.firstName);
			}


			Console.WriteLine (" ");
			Console.WriteLine (" ");
			Console.WriteLine("Lambda operation results");
			Console.WriteLine("sorting by firstName---->");
			var result1 = iList.OrderByDescending (x => x.firstName);
			foreach (person x in result1) 
			{
				Console.WriteLine ("{0},{1}",x.firstName,x.lastName);
			}
			Console.WriteLine("sorting by lastName---->");
			var result2 = iList.OrderByDescending (x => x.lastName);
			foreach (person x in result2) 
			{
				Console.WriteLine ("{0},{1}",x.lastName,x.firstName);
			}

		}
		public class person
		{
			public string firstName;
			public string lastName;
		}
		}

}
