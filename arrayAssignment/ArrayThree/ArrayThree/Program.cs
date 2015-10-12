using System;

namespace ArrayThree
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

			Array.Sort (personArray);
						foreach (Person p in personArray) {
							Console.WriteLine (p.firstName);
						};
		}
	}

	class Person:IComparable<Person>
	{
		public string firstName{ get; set; }
		public string lastName{ get; set; }
		public int age{ get; set; }

				public int CompareTo(Person person)
				{
			       return person.age.CompareTo(this.age);
				}


	}

}
	