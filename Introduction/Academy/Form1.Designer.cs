namespace Academy
{
	partial class Form1
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.rbStudents = new System.Windows.Forms.RadioButton();
			this.rbGroups = new System.Windows.Forms.RadioButton();
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.lblStudCount = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.tabPageTeacheres = new System.Windows.Forms.TabPage();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnGroupAdd = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Controls.Add(this.tabPageTeacheres);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(776, 426);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageStudents.Controls.Add(this.rbStudents);
			this.tabPageStudents.Controls.Add(this.rbGroups);
			this.tabPageStudents.Controls.Add(this.cbDirection);
			this.tabPageStudents.Controls.Add(this.lblStudCount);
			this.tabPageStudents.Controls.Add(this.btnAdd);
			this.tabPageStudents.Controls.Add(this.dgvStudents);
			this.tabPageStudents.Controls.Add(this.cbGroup);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(768, 400);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Студенты";
			// 
			// rbStudents
			// 
			this.rbStudents.AutoSize = true;
			this.rbStudents.Location = new System.Drawing.Point(348, 38);
			this.rbStudents.Name = "rbStudents";
			this.rbStudents.Size = new System.Drawing.Size(73, 17);
			this.rbStudents.TabIndex = 6;
			this.rbStudents.TabStop = true;
			this.rbStudents.Text = "Студенты";
			this.rbStudents.UseVisualStyleBackColor = true;
			this.rbStudents.CheckedChanged += new System.EventHandler(this.rbStudents_CheckedChanged);
			// 
			// rbGroups
			// 
			this.rbGroups.AutoSize = true;
			this.rbGroups.Location = new System.Drawing.Point(280, 38);
			this.rbGroups.Name = "rbGroups";
			this.rbGroups.Size = new System.Drawing.Size(62, 17);
			this.rbGroups.TabIndex = 5;
			this.rbGroups.TabStop = true;
			this.rbGroups.Text = "Группы";
			this.rbGroups.UseVisualStyleBackColor = true;
			this.rbGroups.CheckedChanged += new System.EventHandler(this.rbGroups_CheckedChanged);
			// 
			// cbDirection
			// 
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(7, 34);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(266, 21);
			this.cbDirection.TabIndex = 4;
			this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
			// 
			// lblStudCount
			// 
			this.lblStudCount.AutoSize = true;
			this.lblStudCount.Location = new System.Drawing.Point(279, 13);
			this.lblStudCount.Name = "lblStudCount";
			this.lblStudCount.Size = new System.Drawing.Size(123, 13);
			this.lblStudCount.TabIndex = 3;
			this.lblStudCount.Text = "Количество студентов:";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(687, 8);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgvStudents
			// 
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(7, 61);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.Size = new System.Drawing.Size(755, 333);
			this.dgvStudents.TabIndex = 1;
			// 
			// cbGroup
			// 
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(7, 8);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(266, 21);
			this.cbGroup.TabIndex = 0;
			this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
			// 
			// tabPageTeacheres
			// 
			this.tabPageTeacheres.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeacheres.Name = "tabPageTeacheres";
			this.tabPageTeacheres.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeacheres.Size = new System.Drawing.Size(768, 400);
			this.tabPageTeacheres.TabIndex = 1;
			this.tabPageTeacheres.Text = "Преподаватели";
			this.tabPageTeacheres.UseVisualStyleBackColor = true;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageGroups.Controls.Add(this.btnGroupAdd);
			this.tabPageGroups.Controls.Add(this.dataGridView1);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(768, 400);
			this.tabPageGroups.TabIndex = 2;
			this.tabPageGroups.Text = "Группы";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 40);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(758, 357);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnGroupAdd
			// 
			this.btnGroupAdd.Location = new System.Drawing.Point(687, 11);
			this.btnGroupAdd.Name = "btnGroupAdd";
			this.btnGroupAdd.Size = new System.Drawing.Size(75, 23);
			this.btnGroupAdd.TabIndex = 1;
			this.btnGroupAdd.Text = "Добавить";
			this.btnGroupAdd.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageTeacheres;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.ComboBox cbGroup;
		private System.Windows.Forms.Label lblStudCount;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.RadioButton rbStudents;
		private System.Windows.Forms.RadioButton rbGroups;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.Button btnGroupAdd;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

