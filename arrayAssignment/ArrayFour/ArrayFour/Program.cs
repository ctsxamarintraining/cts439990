using System;
using System.Collections.Generic;

namespace ArrayFour
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] personArray = new Person[3];
			Person p1 = new Person ();
			p1.firstName=@"Divya";
			p1.lastName=@"Vuppala";
			p1.age = 22;

			Person p2 = new Person ();
			p2.firstName=@"Deeraj";
			p2.lastName=@"Vuppala";
			p2.age = 24;

			Person p3 = new Person ();
			p3.firstName=@"Radhika";
			p3.lastName=@"Vuppala";
			p3.age = 43;

			personArray [0] = p1;
			personArray [1] = p2;
			personArray [2] = p3;

			Comparer c = new Comparer ();
			Array.Sort (personArray,c);
			foreach (Person p in personArray) {
				Console.WriteLine (p.firstName);
			};
		}

	}

	class Person
	{
		public string firstName{ get; set; }
		public string lastName{ get; set; }
		public int age{ get; set; }

	}
	class Comparer : IComparer<Person>
		{
			public int Compare(Person p1, Person p2)
			{
				
				return p1.firstName.CompareTo(p2.firstName);
			}
		}

}
	