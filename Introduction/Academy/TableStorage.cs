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
		public SqlDataAdapter Adapter { get => adapter; }
		public TableStorage()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			set = new DataSet();
			//adapter = new SqlDataAdapter();
			//builder = new SqlCommandBuilder(adapter);
		}
		public void GetDataFromBase(string table)
		{
			try
			{
				string cmd = $"SELECT * FROM {table}";
				adapter = new SqlDataAdapter(cmd, connection);
				builder = new SqlCommandBuilder(adapter);
				//adapter.SelectCommand.CommandText = cmd;
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
				string cmd = $"SELECT DISTINCT {columns} FROM {tables} WHERE {condition}";
				adapter = new SqlDataAdapter(cmd, connection);
				builder = new SqlCommandBuilder(adapter);
				//adapter.SelectCommand.CommandText = cmd;
				adapter.Fill(set);
			}
			catch (Exception e)
			{
				throw e;
			}
		}
		public void Insert(string cmd)
		{
			adapter.InsertCommand = new SqlCommand(cmd, connection);
			//adapter.InsertCommand.ExecuteNonQuery();
			adapter.Update(set);
		}
	}
}
