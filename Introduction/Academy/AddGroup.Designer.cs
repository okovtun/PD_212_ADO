namespace Academy
{
	partial class AddGroup
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
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.cbLearningForm = new System.Windows.Forms.ComboBox();
			this.cbTime = new System.Windows.Forms.ComboBox();
			this.tbGroupName = new System.Windows.Forms.TextBox();
			this.clbWeek = new System.Windows.Forms.CheckedListBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lblLearningDaysCode = new System.Windows.Forms.Label();
			this.btnCreateGroup = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbDirection
			// 
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(13, 39);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(328, 21);
			this.cbDirection.TabIndex = 0;
			this.cbDirection.Text = "Выберите направление обучения";
			// 
			// cbLearningForm
			// 
			this.cbLearningForm.FormattingEnabled = true;
			this.cbLearningForm.Location = new System.Drawing.Point(13, 12);
			this.cbLearningForm.Name = "cbLearningForm";
			this.cbLearningForm.Size = new System.Drawing.Size(328, 21);
			this.cbLearningForm.TabIndex = 1;
			this.cbLearningForm.Text = "Форма обучения";
			this.cbLearningForm.SelectedIndexChanged += new System.EventHandler(this.cbLearningForm_SelectedIndexChanged);
			// 
			// cbTime
			// 
			this.cbTime.FormattingEnabled = true;
			this.cbTime.Location = new System.Drawing.Point(13, 66);
			this.cbTime.Name = "cbTime";
			this.cbTime.Size = new System.Drawing.Size(328, 21);
			this.cbTime.TabIndex = 2;
			this.cbTime.Text = "Время обучения";
			// 
			// tbGroupName
			// 
			this.tbGroupName.Location = new System.Drawing.Point(13, 147);
			this.tbGroupName.Name = "tbGroupName";
			this.tbGroupName.Size = new System.Drawing.Size(328, 20);
			this.tbGroupName.TabIndex = 3;
			this.tbGroupName.Text = "Название группы";
			// 
			// clbWeek
			// 
			this.clbWeek.CheckOnClick = true;
			this.clbWeek.ColumnWidth = 45;
			this.clbWeek.FormattingEnabled = true;
			this.clbWeek.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.clbWeek.Location = new System.Drawing.Point(13, 96);
			this.clbWeek.MultiColumn = true;
			this.clbWeek.Name = "clbWeek";
			this.clbWeek.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.clbWeek.Size = new System.Drawing.Size(328, 19);
			this.clbWeek.TabIndex = 5;
			this.clbWeek.SelectedIndexChanged += new System.EventHandler(this.clbWeek_SelectedIndexChanged);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(264, 179);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 6;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// lblLearningDaysCode
			// 
			this.lblLearningDaysCode.AutoSize = true;
			this.lblLearningDaysCode.Location = new System.Drawing.Point(13, 131);
			this.lblLearningDaysCode.Name = "lblLearningDaysCode";
			this.lblLearningDaysCode.Size = new System.Drawing.Size(80, 13);
			this.lblLearningDaysCode.TabIndex = 7;
			this.lblLearningDaysCode.Text = "Дни обучения:";
			// 
			// btnCreateGroup
			// 
			this.btnCreateGroup.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCreateGroup.Location = new System.Drawing.Point(13, 179);
			this.btnCreateGroup.Name = "btnCreateGroup";
			this.btnCreateGroup.Size = new System.Drawing.Size(104, 23);
			this.btnCreateGroup.TabIndex = 8;
			this.btnCreateGroup.Text = "Создать группу";
			this.btnCreateGroup.UseVisualStyleBackColor = true;
			this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
			// 
			// AddGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 214);
			this.Controls.Add(this.btnCreateGroup);
			this.Controls.Add(this.lblLearningDaysCode);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.clbWeek);
			this.Controls.Add(this.tbGroupName);
			this.Controls.Add(this.cbTime);
			this.Controls.Add(this.cbLearningForm);
			this.Controls.Add(this.cbDirection);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AddGroup";
			this.Text = "AddGroup";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.ComboBox cbLearningForm;
		private System.Windows.Forms.ComboBox cbTime;
		private System.Windows.Forms.TextBox tbGroupName;
		private System.Windows.Forms.CheckedListBox clbWeek;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label lblLearningDaysCode;
		private System.Windows.Forms.Button btnCreateGroup;
	}
}