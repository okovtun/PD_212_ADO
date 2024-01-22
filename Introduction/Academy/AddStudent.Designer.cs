namespace Academy
{
	partial class AddStudent
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelFullName = new System.Windows.Forms.Label();
			this.textBoxFullName = new System.Windows.Forms.TextBox();
			this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.labelGroupName = new System.Windows.Forms.Label();
			this.comboBoxGroup = new System.Windows.Forms.ComboBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelFullName
			// 
			this.labelFullName.AutoSize = true;
			this.labelFullName.Location = new System.Drawing.Point(13, 13);
			this.labelFullName.Name = "labelFullName";
			this.labelFullName.Size = new System.Drawing.Size(97, 13);
			this.labelFullName.TabIndex = 1;
			this.labelFullName.Text = "Ф. И. О. студента";
			// 
			// textBoxFullName
			// 
			this.textBoxFullName.Location = new System.Drawing.Point(16, 29);
			this.textBoxFullName.Name = "textBoxFullName";
			this.textBoxFullName.Size = new System.Drawing.Size(309, 20);
			this.textBoxFullName.TabIndex = 2;
			// 
			// dateTimePickerBirthDate
			// 
			this.dateTimePickerBirthDate.Location = new System.Drawing.Point(16, 76);
			this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
			this.dateTimePickerBirthDate.Size = new System.Drawing.Size(309, 20);
			this.dateTimePickerBirthDate.TabIndex = 3;
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Location = new System.Drawing.Point(16, 56);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(89, 13);
			this.labelBirthDate.TabIndex = 4;
			this.labelBirthDate.Text = "Дата рождения:";
			// 
			// labelGroupName
			// 
			this.labelGroupName.AutoSize = true;
			this.labelGroupName.Location = new System.Drawing.Point(19, 108);
			this.labelGroupName.Name = "labelGroupName";
			this.labelGroupName.Size = new System.Drawing.Size(45, 13);
			this.labelGroupName.TabIndex = 5;
			this.labelGroupName.Text = "Группа:";
			// 
			// comboBoxGroup
			// 
			this.comboBoxGroup.FormattingEnabled = true;
			this.comboBoxGroup.Location = new System.Drawing.Point(16, 124);
			this.comboBoxGroup.Name = "comboBoxGroup";
			this.comboBoxGroup.Size = new System.Drawing.Size(309, 21);
			this.comboBoxGroup.TabIndex = 6;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(169, 151);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 7;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(250, 151);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// AddStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 186);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.comboBoxGroup);
			this.Controls.Add(this.labelGroupName);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.dateTimePickerBirthDate);
			this.Controls.Add(this.textBoxFullName);
			this.Controls.Add(this.labelFullName);
			this.Name = "AddStudent";
			this.Text = "AddStudent";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelFullName;
		private System.Windows.Forms.TextBox textBoxFullName;
		private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
		private System.Windows.Forms.Label labelBirthDate;
		private System.Windows.Forms.Label labelGroupName;
		private System.Windows.Forms.ComboBox comboBoxGroup;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}