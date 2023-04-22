using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_3
{
	internal class Employee
	{
		string _name;
		int _age;
		string _designation;
		string _city;

		public string Name
		{ get { return _name; } set {  _name = value; } }

		public int Age { get { return _age; } set { _age = value; } }
		public string Designation
		{ get { return _designation; } set { _designation = value; } }

		public string City { get { return _city; }
			set
			{
				_city = value;
			} }

		public Employee() { }
		public Employee(string name, int age, string designation, string city)
		{
			Name = name;
			Age = age;
			Designation = designation;
			City = city;
		}

		public override string ToString()
		{
			return string.Format("{0,-21}{1,-6}{2,-21}{3,-20}", this.Name, this.Age, this.Designation, this.City);
		}

	}
}
