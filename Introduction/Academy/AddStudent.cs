using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class AddStudent : Form
	{
		public string FullName { get; set; }
		public DateTime BirthDate { get; set; }
		public string Group { get; set; }
		public ComboBox GroupCombo
		{
			get
			{
				return comboBoxGroup;
			}
		}
		public AddStudent()
		{
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			FullName = textBoxFullName.Text;
			BirthDate = dateTimePickerBirthDate.Value;
			Group = comboBoxGroup.SelectedItem.ToString();
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
