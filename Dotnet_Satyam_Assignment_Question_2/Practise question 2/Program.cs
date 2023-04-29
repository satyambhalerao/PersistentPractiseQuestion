using System.Data.SqlClient;
using System.Data;
using Azure.Identity;

internal class dissconeted
{
	static SqlConnection conn;
	static SqlDataAdapter adapter;
	static DataSet ds;
	static SqlCommandBuilder builder;
	static void Main(string[] args)
	{
		bool on = true;
		while(on)
		{
			Console.WriteLine("Menu");
			Console.WriteLine("1)Enter Data \n 2)Update Data \n 3)Delete DAta \n 4)Display Data \n 5)Exit");
			int choice = int.Parse(Console.ReadLine());
			switch(choice)
			{
				case 1:
					FillData();
					InsertDetails();
					DisplayDetaiks();
					break;
				case 2:
					FillData();
					UpdateDetails();
					break;
				case 3:
					FillData();
					DeleteDetails();
					break;
				case 4:
					FillData();
					DisplayDetaiks();
				break;
				case 5:
					on = false;
				break;
				default: Console.WriteLine("Enter proper value from meun");break;
			}

		}
	}
	public static void FillData()
	{
		conn = new SqlConnection("Data Source=laptop-29ln4mjb;Initial Catalog=EmplyoeeDB;Integrated Security=True");
		adapter = new SqlDataAdapter("Select * from Employee",conn);
		ds = new DataSet();
		builder = new SqlCommandBuilder(adapter);
		adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
		adapter.Fill(ds, "Employee");
	}
	public static void DisplayDetaiks()
	{
		try
		{
			string format = "|{0,-10}|{1,-20}|{2,-15}|{3,-15}|";
			Console.WriteLine(format,"ID","Name","Date","Department");
			Console.WriteLine(new string('-', 62));
			foreach (DataRow ds in ds.Tables["Employee"].Rows)
			{
				Console.WriteLine(format,ds[0],ds[1],((DateTime)ds[2]).ToString("MM/dd/yyyy"), ds[3]);
			}
		}
		catch(SqlException ex) 
		{
			Console.WriteLine(ex.Message);
		}
		
	}

	public static void InsertDetails()
	{
		try
		{
			DataRow nr = ds.Tables["Employee"].NewRow();
			Console.WriteLine("Enter Emplyoee ID");
			nr[0] = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Emplyoee name");
			nr[1] = Console.ReadLine();
			Console.WriteLine("Enter Emplyoee Date of joining");
			nr[2] = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("Enter Emplyoee Deparment");
			nr[3] = Console.ReadLine();
			ds.Tables["Employee"].Rows.Add(nr);
			adapter.Update(ds.Tables["Employee"]);
			Console.WriteLine("Record insterted");
		}
		catch (ArgumentNullException ex) 
			{
			Console.WriteLine(ex.Message);
		}
		catch(FormatException fe)
		{
			Console.WriteLine(fe.Message);
		}

	}

	public static void UpdateDetails()
	{
		try
		{
			Console.WriteLine("Enter Employee Id to update");
			int id = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter updated deparment");
			string deparment = Console.ReadLine();
			DataRow dr = ds.Tables[0].Rows.Find(id);
			dr[3] = deparment;
			adapter.Update(ds.Tables[0]);
			Console.WriteLine("Record Updated");
		}
		catch (ArgumentNullException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch (FormatException fe)
		{
			Console.WriteLine(fe.Message);
		}
	}

	public static void DeleteDetails()
	{
		try
		{
			Console.WriteLine("Enter Employee Id to Delete");
			int id  = int.Parse(Console.ReadLine());
			DataRow dr = ds.Tables[0].Rows.Find(id);
			dr.Delete();
			adapter.Update(ds.Tables[0]);
			Console.WriteLine("Record Deleted");
		}
		catch(ArgumentNullException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch(FormatException fe)
		{
			Console.WriteLine(fe.Message);
		}
	}
}