using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statment_1
{
		 class Employee : IComparable<Employee>
	{
		string name;
		int salary;

		public string Name
		{
			get { return name; } set {  name = value; }
		}

		public int Salray
		{
			get { return salary; } set {salary=value; }
		}
		public Employee() { }

		public Employee(string name,int salary) 
		{
			Name = name;
			Salray = salary;
		}

		public int CompareTo(Employee other)
		{
			if(Salray.CompareTo(other.Salray) != 0)
			{
				return Salray.CompareTo(other.Salray);
			}
			else
			{
				return Name.CompareTo(other.Name);
			}
		}

		public override string ToString() 
		{
			return this.Name +" - "+this.Salray;
		}
	}
}
