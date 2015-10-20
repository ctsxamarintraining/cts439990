using System;
using System.Collections.Generic;

namespace Day6Five
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Dictionary<Product,int> personList1 = new Dictionary<Product,int>(new MyEqualityComparer()){
				{new Product{id=1,name="Mac"},1},
				{new Product{id=2,name="iPad"},2},
				{new Product{id=1,name="Mac"},3}
			};
			Console.WriteLine ("IEqualityComparer");

			foreach (Product p in personList1.Keys)
				Console.WriteLine (p.name);
			List<Product> myList = new List<Product> {
				new Product{ id = 1, name = "Mac" },
				new Product{ id = 6, name = "iPhone" }
			};
			Console.WriteLine (" ");
			Console.WriteLine (" ");
			Console.WriteLine ("IComparer");
			myList.Sort (new MyComparer ());
			foreach(Product p in myList)
				Console.WriteLine (p.name);
		}
	}
	class Product{
		public string name;
		public int id;
	}
	class MyEqualityComparer : IEqualityComparer<Product>{
		
		public bool Equals (Product x, Product y)
		{
			return x.id==y.id;
		}
		public int GetHashCode (Product obj)
		{
			return obj.GetHashCode ();
		}

	}
	class MyComparer : IComparer<Product>{
		
		public int Compare (Product x, Product y)
		{
			return x.name.CompareTo (y.name);
		}

	}
}

