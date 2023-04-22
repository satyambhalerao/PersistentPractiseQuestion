using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Problem_Statment_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Employee> employees = new List<Employee>();

			Console.WriteLine("Enter Details of 5 empyoee");
			for(int i = 0; i < 5; i++) 
			{
				Console.WriteLine("Enter your name");
				string name = Console.ReadLine();

				while(string.IsNullOrWhiteSpace(name))
				{
					Console.WriteLine("Invalid name: Enter your name again");
					name = Console.ReadLine();
				}
				Console.WriteLine("Enter Salary");
				int salary = int.Parse(Console.ReadLine());
				
				while(salary <= 0)
				{
					Console.WriteLine("invaild Salary : Enter your salary again");
					salary = int.Parse(Console.ReadLine());
				}

				employees.Add(new Employee ( name, salary ));
			}
			employees.Sort();
			foreach(Employee employee in employees)
			{
				Console.WriteLine(employee);
			}
		}
	}
}