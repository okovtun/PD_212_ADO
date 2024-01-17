using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
	class Library
	{
		string connectionString;
		SqlConnection connection;
		public SqlCommand cmd { get; set; }
		public Library(string connectionString)
		{
			this.connectionString = connectionString;
			connection = new SqlConnection(connectionString);
		}
		~Library()
		{
			connection.Close();
		}

		public void InsertAuthor(string last_name, string first_name)
		{
			try
			{
				connection.Open();
				string command =
						$@"
				IF NOT EXISTS (SELECT id FROM Authors WHERE last_name='{last_name}' AND first_name='{first_name}') 
				BEGIN
				INSERT INTO Authors (last_name, first_name) 
				VALUES ('{last_name}', '{first_name}')
				END
				";
				//@ - RAW-строка
				cmd = new SqlCommand(command, connection);
				cmd.ExecuteNonQuery();
			}
			finally
			{
				if (connection != null) connection.Close();
			}
		}
		public void InsertBook(string last_name, string first_name, string title, string price, string pages)
		{
			try
			{
				connection.Open();
				string command =
						$@"
				IF NOT EXIST (SELECT id FROM Authors WHERE last_name={last_name} AND first_name={first_name}) 
				BEGIN 
				INSERT INTO Authors (last_name, first_name) 
				VALUES ({last_name}, {first_name});

				INSERT INTO 
				Books	(author, title, price, pages)
				VALUES	((SELECT id FROM Authors WHERE last_name={last_name}, first_name={first_name}), '{title}', {price}, {pages});
				";
				//@ - RAW-строка
				cmd = new SqlCommand(command, connection);
				cmd.ExecuteNonQuery();
			}
			finally
			{
				if (connection != null) connection.Close();
			}
		}
		public void SelectAuthors()
		{
			try
			{
				connection.Open();
				string command = @"SELECT * FROM Authors";
				cmd = new SqlCommand(command, connection);
				SqlDataReader rdr = cmd.ExecuteReader();
				Console.WriteLine($"{rdr.GetName(0).PadRight(10)} {rdr.GetName(1).PadRight(15)} {rdr.GetName(2).PadRight(15)}");
				while (rdr.Read())
				{
					Console.WriteLine($"{rdr[0].ToString().PadRight(10)} {rdr[1].ToString().PadRight(15)} {rdr[2].ToString().PadRight(15)}");
				}
			}
			finally
			{
				if (connection != null) connection.Close();
			}
		}

	}
}
