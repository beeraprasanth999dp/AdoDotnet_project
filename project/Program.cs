using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
string connectionString="Data Source=ACU-HYD-LT-2023\\SQLEXPRESS;Initial Catalog=AdoDotnet;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=SQL Server Management Studio;Command Timeout=0;";
SqlConnection con=new SqlConnection(connectionString);
con.Open();
Console.WriteLine("Connected Successfully!");
SqlDataAdapter adapter=new SqlDataAdapter("Select * from Employee",con);
SqlCommandBuilder builder=new SqlCommandBuilder(adapter);
DataTable table=new DataTable();
adapter.Fill(table);
Console.WriteLine("Before Modisfication:");
foreach(DataRow row  in table.Rows)
{
    System.Console.WriteLine(row["Id"]+" "+row["Name"]+" "+row["Salary"]);
   
}
table.Rows[4]["Salary"]=35000;
System.Console.WriteLine("After Modification-----");
foreach(DataRow row  in table.Rows)
{
    System.Console.WriteLine(row["Id"]+" "+row["Name"]+" "+row["Salary"]);
   
}




con.Close();
