using System;
using System.Collections.Generic;
using System.Linq;

namespace sample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		 

			List<Person> persons = new List<Person> () {
				new Person { PersonID = 1, car = "Ferrari" }, 

				new Person { PersonID = 2, car = "Audi"    },
				new Person { PersonID = 1, car = "BMW"     }
			};


			var results = from p in persons
				group p.car by p.PersonID into g
				select new { PersonID = g.Key, Cars = g.ToList() };
			foreach (var res in results) 
			{
				Console.WriteLine (res.PersonID);
				foreach (var x in res.Cars) {
					Console.WriteLine (x);
				}
			}
		}
	}

	class Person { 
		internal int PersonID; 
		internal string car  ; 
	}
}
