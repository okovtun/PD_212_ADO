using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Academy
{
	public class TableStorage
	{
		SqlConnection connection;
		SqlDataAdapter adapter;
		DataSet set;
		SqlCommandBuilder builder;
		public DataSet Set { get => set; }
		public TableStorage()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			set = new DataSet();
		}
		public void GetDataFromBase(string table)
		{
			try
			{
				string cmd = $"SELECT * FROM {table}";
				adapter = new SqlDataAdapter(cmd, connection);
				builder = new SqlCommandBuilder(adapter);
				adapter.Fill(set, table);
			}
			catch (Exception e)
			{
				throw e;
			}
		}
		public void GetDataFromBase(string tables, string columns, string condition)
		{
			try
			{
				string cmd = $"SELECT {columns} FROM {tables} WHERE {condition}";
				adapter = new SqlDataAdapter(cmd, connection);
				builder = new SqlCommandBuilder(adapter);
				adapter.Fill(set);
			}
			catch (Exception e)
			{
				throw e;
			}
		}

	}
}
