using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Library2
{
	public partial class Form1 : Form
	{
		string connectionString;
		SqlConnection connection;
		SqlDataReader reader;
		DataTable table;

		public Form1()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			LoadTablesToComboBox();
		}

		void LoadTablesToComboBox()
		{
			string commandLine = @"SELECT table_name FROM information_schema.tables";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				cbTables.Items.Add(reader[0]);
			}
			reader.Close();
			connection.Close();
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			//if (rtbQuery.Text.Length == 0)
			//{
			//	MessageBox.Show(this, "Введите запрос", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	return;
			//}

			try
			{
				string cmdLine = rtbQuery.Text;
				SqlCommand cmd = new SqlCommand(cmdLine, connection);

				connection.Open();
				reader = cmd.ExecuteReader();

				//Создаем таблицу, которая бует хранить результаты выборки:
				table = new DataTable();
				//Создаем шапку этой таблицы:
				for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
				//Заполняем строки содержимым:
				while (reader.Read())
				{
					//создаем новую строку с заданным набором полей:
					DataRow row = table.NewRow();
					//Заполняем строку данными:
					for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
					//Добавляем заполненную строку в таблицу:
					table.Rows.Add(row);
				}
				dgwResults.DataSource = table;
			}
			catch (Exception exception)
			{
				MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (reader != null) reader.Close();
				if (connection != null) connection.Close();
			}
		}

		private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
		{
			string commandLine = $@"SELECT * FROM {cbTables.SelectedItem}";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			reader = cmd.ExecuteReader();
			table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
				table.Rows.Add(row);
			}
			dgwResults.DataSource = table;

			reader.Close();
			connection.Close();
		}
	}
}
