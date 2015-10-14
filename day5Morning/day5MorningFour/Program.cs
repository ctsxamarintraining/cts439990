using System;
using System.Linq;
using System.Collections.Generic;

namespace day5MorningFour
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] personArray1 = new Person[] {
				new Person{Name="madhu",Id=440054,City="hyderabad"},
				new Person{Name="santosh",Id=440221,City="Nalgonda"}
			};

			Person[] personArray2 = new Person[3];

			Person p1=new Person();
			p1.Name="Divya";
			p1.Id=439990;
			p1.City="Hyderabad";
			personArray2[0]=p1;

			Person p2=new Person();
			p2.Name="Vasundhara";
			p2.Id=440092;
			p2.City="Hyderabad";
			personArray2[1]=p2;

			Person p3=new Person();
			p3.Name="Sravan";
			p3.Id=440088;
			p3.City="Warangal";
			personArray2[2]=p3;

			var emps1 = from emp in personArray1
				select new { personName = emp.Name, personID = emp.Id};

			foreach (var row in emps1) {
				Console.WriteLine (row);
			}

			var emps2 = from emp in personArray2
				select new { personName = emp.Name, personID = emp.Id, City = emp.City };

			foreach (var row in emps2) {
				Console.WriteLine (row);
			}
		}
		class Person
		{
				public string Name{get;set;}
				public int Id{get;set;}
			    public string City{get;set;}
		}
	}
}
