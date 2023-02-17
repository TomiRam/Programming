using System;
using System.Data.SqlClient;
using System.Data;
using static System.Console;

namespace AccessingDatabase
{
    class Program
    {
        static void Main(string[] args)
        {     

            //Create the object of SqlConnection class to connect with database sql server
           using( SqlConnection conn=new SqlConnection())
           {
               //prepare conectio string
               conn.ConnectionString = "server=ACER; database=BankingTransactions; Integrated Security=True";
               
               try
               {
                 
                   //Prepare SQL command that we want to query
                   SqlCommand cmd = new SqlCommand();
                   cmd.CommandType = CommandType.Text;
                   // cmd.CommandText = "SELECT * FROM MYTABLE";
                   cmd.CommandText = "SELECT id FROM UserRegistration";  
                   cmd.Connection = conn;

                   // open database connection.
                   conn.Open();
                   
                   WriteLine("Connection Open ! ");

                   //Execute the query 
                 SqlDataReader sdr=  cmd.ExecuteReader();

                 ////Retrieve data from table and Display result
                   while(sdr.Read())
                   {
                       int id = (int)sdr["id"];
                       WriteLine(id);
                   }
                   //Close the connection
                   conn.Close();
               }
               catch (Exception ex)
               {
                   WriteLine("Can not open connection !");
                  
               }
               
           }
        }
    }
}
