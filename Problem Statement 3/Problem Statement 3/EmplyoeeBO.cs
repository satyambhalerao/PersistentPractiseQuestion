using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_3
{
	internal class EmplyoeeBO
	{
		public void DisplayEmployeeDetails(List<Employee> employeeList,string name)
		{
			bool found = false;
			foreach (Employee employee in employeeList)
			{
				if (employee.Name == name)
				{
					Console.WriteLine(employee.ToString());
					found = true;
				}
			}
			if (!found)
			{
				Console.WriteLine("Employee name not found");
			}

		}
		public void DisplayYoungestEmployeeDetails(List<Employee> employeeList)
		{
			int smallestage = employeeList[0].Age;
			int index = 0;
			foreach (Employee employee in employeeList)
			{
				if(employee.Age < smallestage)
				{
					index = employeeList.IndexOf(employee);
				}
			}
			Console.WriteLine(employeeList[index].ToString());
		}

		public void DisplayEmployeesFromCity(List<Employee> employeeList,string cname)
			{
				bool check = false;
				foreach(Employee employee in employeeList)
				{
					if (employee.City == cname) {
					Console.WriteLine(employee.ToString());
						check = true;
							}
				}

				if(!check)
				{
					Console.WriteLine("City named"+cname+" not found");
				}
			}
	}
}
