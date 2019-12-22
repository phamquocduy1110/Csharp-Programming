namespace WindowsFormsExercise_05_10_2019
{
    partial class HomePageForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtaDatabase = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.llblStudentStatistic = new System.Windows.Forms.LinkLabel();
            this.llblExit = new System.Windows.Forms.LinkLabel();
            this.llblAddNewStudent = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStudentDatabaseSystemManagement = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaDatabase)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dtaDatabase);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 738);
            this.panel1.TabIndex = 0;
            // 
            // dtaDatabase
            // 
            this.dtaDatabase.AllowUserToAddRows = false;
            this.dtaDatabase.AllowUserToDeleteRows = false;
            this.dtaDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtaDatabase.Location = new System.Drawing.Point(229, 0);
            this.dtaDatabase.Name = "dtaDatabase";
            this.dtaDatabase.ReadOnly = true;
            this.dtaDatabase.Size = new System.Drawing.Size(1137, 738);
            this.dtaDatabase.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.monthCalendar);
            this.panel5.Controls.Add(this.llblStudentStatistic);
            this.panel5.Controls.Add(this.llblExit);
            this.panel5.Controls.Add(this.llblAddNewStudent);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 738);
            this.panel5.TabIndex = 0;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(2, 102);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // llblStudentStatistic
            // 
            this.llblStudentStatistic.AutoSize = true;
            this.llblStudentStatistic.BackColor = System.Drawing.Color.LightGray;
            this.llblStudentStatistic.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblStudentStatistic.ForeColor = System.Drawing.Color.White;
            this.llblStudentStatistic.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblStudentStatistic.LinkColor = System.Drawing.Color.Black;
            this.llblStudentStatistic.Location = new System.Drawing.Point(38, 355);
            this.llblStudentStatistic.Name = "llblStudentStatistic";
            this.llblStudentStatistic.Size = new System.Drawing.Size(141, 23);
            this.llblStudentStatistic.TabIndex = 2;
            this.llblStudentStatistic.TabStop = true;
            this.llblStudentStatistic.Text = "Student Statistic";
            // 
            // llblExit
            // 
            this.llblExit.AutoSize = true;
            this.llblExit.BackColor = System.Drawing.Color.LightGray;
            this.llblExit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblExit.ForeColor = System.Drawing.Color.White;
            this.llblExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblExit.LinkColor = System.Drawing.Color.Black;
            this.llblExit.Location = new System.Drawing.Point(80, 410);
            this.llblExit.Name = "llblExit";
            this.llblExit.Size = new System.Drawing.Size(40, 23);
            this.llblExit.TabIndex = 1;
            this.llblExit.TabStop = true;
            this.llblExit.Text = "Exit";
            // 
            // llblAddNewStudent
            // 
            this.llblAddNewStudent.AutoSize = true;
            this.llblAddNewStudent.BackColor = System.Drawing.Color.LightGray;
            this.llblAddNewStudent.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAddNewStudent.ForeColor = System.Drawing.Color.White;
            this.llblAddNewStudent.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblAddNewStudent.LinkColor = System.Drawing.Color.Black;
            this.llblAddNewStudent.Location = new System.Drawing.Point(38, 301);
            this.llblAddNewStudent.Name = "llblAddNewStudent";
            this.llblAddNewStudent.Size = new System.Drawing.Size(144, 23);
            this.llblAddNewStudent.TabIndex = 0;
            this.llblAddNewStudent.TabStop = true;
            this.llblAddNewStudent.Text = "Add new student";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.lblStudentDatabaseSystemManagement);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1366, 102);
            this.panel3.TabIndex = 2;
            // 
            // lblStudentDatabaseSystemManagement
            // 
            this.lblStudentDatabaseSystemManagement.Font = new System.Drawing.Font("Century Schoolbook", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDatabaseSystemManagement.Location = new System.Drawing.Point(3, 9);
            this.lblStudentDatabaseSystemManagement.Name = "lblStudentDatabaseSystemManagement";
            this.lblStudentDatabaseSystemManagement.Size = new System.Drawing.Size(1360, 84);
            this.lblStudentDatabaseSystemManagement.TabIndex = 0;
            this.lblStudentDatabaseSystemManagement.Text = "    Student Database System Management";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(918, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 636);
            this.panel4.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(443, 348);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 738);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaDatabase)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView dtaDatabase;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel llblAddNewStudent;
        private System.Windows.Forms.LinkLabel llblExit;
        private System.Windows.Forms.LinkLabel llblStudentStatistic;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblStudentDatabaseSystemManagement;
    }
}

