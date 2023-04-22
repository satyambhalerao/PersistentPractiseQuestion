
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name, nametofind;
			int age, count;
			string des;
			string city, citytofind;
			List<Employee> employees = new List<Employee>();
			EmplyoeeBO emplyoeeBO = new EmplyoeeBO();
			Console.WriteLine("Enter number of emplyoee details");
			count=int.Parse(Console.ReadLine());
			while(count > 0)
			{
				Console.WriteLine("Enter emplyoee name");
				name = Console.ReadLine();
				Console.WriteLine("Enter emplyoee age");
				age = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter emplyoee designation");
				des = Console.ReadLine();
				Console.WriteLine("Enter emplyoee city");
				city = Console.ReadLine(); 
				employees.Add(new Employee(name,age,des,city));
				count--;
			}
			bool exit = true;
			while(exit)
			{
				Console.WriteLine("1)Find emplyoee by name\n2)Find youngest emplyoee\n3)Find emplyoee by city\n4)Exit");
				int choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Console.WriteLine("Enter Emplyoee name to find");
						nametofind = Console.ReadLine();
						emplyoeeBO.DisplayEmployeeDetails(employees, nametofind);
						break;
					case 2:
						emplyoeeBO.DisplayYoungestEmployeeDetails(employees);
						break;
					case 3:
						Console.WriteLine("Enter the city to find empyoee");
						citytofind = Console.ReadLine();
						emplyoeeBO.DisplayEmployeesFromCity(employees, citytofind);
						break;
					case 4:
						exit = false;
						break;
					default:
						Console.WriteLine("Enter correct value");
						break;
				}

			}
		}
	}
}