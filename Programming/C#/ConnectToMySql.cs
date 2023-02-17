using System;
using MySql.Data.MySqlClient;
using static.System.Console;

namespace Connect to MySql
{ 
	class Program 
	{
		static void Main(string[] args)
		{	
			var connString = string.Format(
				"Server ={0};Databse={1};port={2}"+
				";User Id={3};password{4}",
				host, dataBase, port, userName, password);

			var conn= new.MySqlConnection(connString);
			conn.Open();

			var command = conn.CreateCommand();
			command.CommandText=@"
			SELECT
			Language, Percentage
			FROM countrylanguage 
			WHERE CountryCode ='FIN'
			ORDER BY Percentage DESC";

			var reader = command.ExecuteReader();
			//get  data

			if(!reader.Read()){
				return;
			}
			WriteLine(reader.GetString(0)+":"+
				reader.GetFloat("Percentage"));

			conn.Close();
			
		}

	}
}