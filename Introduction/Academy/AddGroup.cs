﻿using System;
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
using System.Runtime.InteropServices;

namespace Academy
{
	public partial class AddGroup : Form
	{
		Form1 mainForm;
		private string connectionString;
		SqlConnection connection;
		SqlDataAdapter adapter;     //Вытягивает результаты запросов из Базы, и сохраняет их в DataSet
		DataSet set;
		SqlCommandBuilder builder;
		public System.Windows.Forms.ComboBox CBDirection { get => cbDirection; }
		public System.Windows.Forms.ComboBox CBLearningForm { get => cbLearningForm; }
		public System.Windows.Forms.ComboBox CBLearningTime { get => cbTime; }
		string[] week = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
		CheckBox[] cbWeek;
		public AddGroup(Form1 mainForm)
		{
			this.mainForm = mainForm;
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			GetDataFromBase();
			mainForm.LoadDataToComboBox(cbLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
			//mainForm.LoadDataToComboBox(cbDirection, "Directions", "direction_name", "Выберите направление обучения");
			mainForm.LoadDataToComboBox(cbTime, "LearningTimes", "time_name", "Выберите время обучения");
			cbWeek = new CheckBox[7];
		}
		byte GetBitSet()
		{
			byte days = 0;

			#region PrintInConsole
			//AllocConsole();
			//Console.Write("Days:\t");
			//for (int i = 0; i < clbWeek.CheckedItems.Count; i++)
			//{
			//	Console.Write(clbWeek.CheckedItems[i] + "\t");
			//}
			//Console.WriteLine();
			//Console.Write("Nums:\t");
			//for (int i = 0; i < clbWeek.CheckedIndices.Count; i++)
			//{
			//	Console.Write(clbWeek.CheckedIndices[i]+"\t");
			//}
			//Console.WriteLine();
			//Console.WriteLine("\n-------------------------------------\n"); 
			#endregion

			for (int i = 0; i < clbWeek.CheckedIndices.Count; i++)
			{
				//byte day = (byte)Math.Pow(2, clbWeek.CheckedIndices[i]);
				//days += day;
				byte day = 1;
				day <<= clbWeek.CheckedIndices[i];
				days |= day;
				/*
				--------------------------------- 
				<< (побитовый сдвиг влево) - это бинарный оператор, который сдвигает число на заданное количество бит влево.
											 Сдвиг числа на 1 бит  влево увеличивает число в два	раза (выполняет умножение числа на 2)
											 Сдвиг числа на 2 бита влево увеличивает число в четыре раза (выполняет умножение числа на 4)
											 Сдвиг числа на 3 бита влево увеличивает число в восемь раз  (выполняет умножение числа на 8)
				--------------------------------- 
				| (побитовое сложение, побитовый OR) - если соответствующий бит хотя бы в одном операнде == 1, то этот же бит результат будет 1.
				--------------------------------- 
				Все побитовые операторы можно комбинировать с оператором присваивания.
				--------------------------------- 
				*/
			}

			return days;
		}
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		void GetDataFromBase()
		{
			try
			{
				set = new DataSet();
				string cmd = $@"SELECT * FROM Directions";
				adapter = new SqlDataAdapter(cmd, connection);
				builder = new SqlCommandBuilder(adapter);
				adapter.Fill(set, "Directions");

				adapter.SelectCommand.CommandText = $@"SELECT * FROM LearningTimes";
				builder.DataAdapter = adapter;
				adapter.Fill(set, "LearningTimes");
			}
			catch (Exception e)
			{
				MessageBox.Show(this, e.Message);
			}
		}
		string GenerateGroupName()
		{
			//PD_212 - Программирование, День, Поток №212
			//SD_212 - Сетевые технологии, День, Поток 212
			//VSU_213 - Воскресенье, Сети, Утро 213й поток
			//Java_326
			//if (cbLearningForm.SelectedIndex == 0) return "Выберите форму обучения";
			//if (cbDirection.SelectedItem == null || cbDirection.SelectedItem.ToString() == "Выберите направление обучения") return "Выберите направление обучения";
			//if (cbTime.SelectedIndex == 0) return "Выберите время обучения";
			if (!AllCombosOK()) return "Что-то пошло не так :-(";
			string group_name = "";
			if (cbLearningForm.SelectedItem.ToString() != "Годичные курсы")
			{
				if (cbLearningForm.SelectedItem.ToString() == "Полустационар") group_name += clbWeek.SelectedItem.ToString();
				//if (cbDirection.SelectedItem.ToString() == "Разработка программного обеспечения")
				{
					//DataRow[] rows = set.Tables["Directions"].Select("direction_name='Разработка программного обеспечения'");
					//DataRow row = rows[0];
					//group_name += row["direction_code_name"];
					group_name +=
						set.Tables["Directions"].Select($"direction_name='{cbDirection.SelectedItem.ToString()}'")[0]["direction_code_name"];
					group_name +=
						set.Tables["LearningTimes"].Select($"time_name='{CBLearningTime.SelectedItem.ToString()}'")[0]["time_code_name"];
				}
			}
			group_name += "_";
			return group_name;
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			tbGroupName.Text = GenerateGroupName();
		}

		private void cbLearningForm_SelectedIndexChanged(object sender, EventArgs e)
		{
			//			mainForm.LoadDataToComboBox
			//				(
			//				cbDirection,
			//				"Directions, LearningForms, LearningFormsDirectionsRelation",
			//				"direction_name",
			//				"Выберите форму обучения",
			//				$@"
			//WHERE	LearningFormsDirectionsRelation.learning_form	= LearningForms.form_id
			//AND		LearningFormsDirectionsRelation.direction		= Directions.direction_id
			//AND		form_name = {cbLearningForm.SelectedItem.ToString()}
			//"
			//				);

			cbDirection.Items.Clear();
			if (cbLearningForm.SelectedIndex != 0)
				mainForm.LoadDataFromStorageToComboBox
								(
								cbDirection,
								"Directions, LearningForms, LearningFormsDirectionsRelation",
								"direction_name",
								"Выберите форму обучения",
								$@"
		LearningFormsDirectionsRelation.learning_form	= LearningForms.form_id
AND		LearningFormsDirectionsRelation.direction		= Directions.direction_id
AND		form_name = '{cbLearningForm.SelectedItem.ToString()}'
"
								);
		}

		private void clbWeek_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblLearningDaysCode.Text = $"Дни обучения: {GetBitSet()}";
		}
		bool ComboBoxOK(ComboBox comboBox)
		{
			if (comboBox.SelectedItem == null) return false;
			if (comboBox.SelectedItem.ToString().Contains(" обучения")) return false;
			return true;
		}
		bool AllCombosOK()
		{
			string message = "";
			if (cbLearningForm.SelectedIndex == 0) message = "Выберите форму обучения";
			else if (cbDirection.SelectedItem == null || cbDirection.SelectedItem.ToString() == "Выберите направление обучения") message = "Выберите направление обучения";
			else if (cbTime.SelectedIndex == 0) message = "Выберите время обучения";
			if (message.Length > 0)
			{
				MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void btnCreateGroup_Click(object sender, EventArgs e)
		{
			if (AllCombosOK() == false) return;
			//if (
			//	!ComboBoxOK(cbLearningForm) && 
			//	!ComboBoxOK(cbDirection) &
			//	!ComboBoxOK(cbTime)
			//	)
			//{
			//	MessageBox.Show(this, "Ничего не выбрано", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	return;
			//}
			bool wrong_days = false;
			if (cbLearningForm.SelectedItem.ToString() == "Стационар"		&& clbWeek.CheckedItems.Count != 3) wrong_days = true;
			if (cbLearningForm.SelectedItem.ToString() == "Полустационар"	&& clbWeek.CheckedItems.Count != 1) wrong_days = true;
			if (cbLearningForm.SelectedItem.ToString() == "Годичные курсы"	&& clbWeek.CheckedItems.Count != 2) wrong_days = true;
			if (wrong_days) MessageBox.Show(this, "Проверьте дни обучения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else			MessageBox.Show(this, "Все хорошо ;-)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (wrong_days) return;
		}
	}
}