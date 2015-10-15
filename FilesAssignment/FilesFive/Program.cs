using System;
//using System.Web;
using Newtonsoft.Json;

namespace FilesFive
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			Person personobj = new Person() {
				Name="Divya",ID=439990,DepartmentName="Mobility",DepartmentID=78977099,Company="Cognizant",City="Hyderabad",Salary=25000
			};

			//serialization
			string output = JsonConvert.SerializeObject(personobj);
			Console.Write ("Serialized Data:{0}",output);
			//Deserialization
			Console.WriteLine ("DeSerialized Data:{0}",JsonConvert.DeserializeObject(output));
		}
	}

	public class Person
	{
		public string Name{ get; set; }
		public int ID{ get; set; }
		public string DepartmentName{ get; set; }
		public int DepartmentID{ get; set; }
		public string Company{ get; set; }
		public string City{ get; set; }
		public int Salary{ get; set; }

	}
}