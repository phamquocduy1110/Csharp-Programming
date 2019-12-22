namespace Family_Members_Information_14_11_2019
{
    partial class FormInputPersonalInformation
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.radLiving = new System.Windows.Forms.RadioButton();
            this.radDeceassed = new System.Windows.Forms.RadioButton();
            this.radUnknown = new System.Windows.Forms.RadioButton();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioFemales = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblBirthplace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblFather = new System.Windows.Forms.Label();
            this.lblMother = new System.Windows.Forms.Label();
            this.lblSpouse = new System.Windows.Forms.Label();
            this.btnBackToHomePage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(12, 80);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(94, 24);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new family member";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(146, 75);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(316, 29);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.TextChanged += new System.EventHandler(this.TxtFullName_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(12, 125);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 24);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // radLiving
            // 
            this.radLiving.AutoSize = true;
            this.radLiving.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLiving.Location = new System.Drawing.Point(146, 212);
            this.radLiving.Name = "radLiving";
            this.radLiving.Size = new System.Drawing.Size(77, 28);
            this.radLiving.TabIndex = 4;
            this.radLiving.TabStop = true;
            this.radLiving.Text = "Living";
            this.radLiving.UseVisualStyleBackColor = true;
            this.radLiving.CheckedChanged += new System.EventHandler(this.RadLiving_CheckedChanged);
            // 
            // radDeceassed
            // 
            this.radDeceassed.AutoSize = true;
            this.radDeceassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDeceassed.Location = new System.Drawing.Point(241, 212);
            this.radDeceassed.Name = "radDeceassed";
            this.radDeceassed.Size = new System.Drawing.Size(123, 28);
            this.radDeceassed.TabIndex = 5;
            this.radDeceassed.TabStop = true;
            this.radDeceassed.Text = "Deceassed";
            this.radDeceassed.UseVisualStyleBackColor = true;
            this.radDeceassed.CheckedChanged += new System.EventHandler(this.radDeceassed_CheckedChanged);
            // 
            // radUnknown
            // 
            this.radUnknown.AutoSize = true;
            this.radUnknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUnknown.Location = new System.Drawing.Point(370, 212);
            this.radUnknown.Name = "radUnknown";
            this.radUnknown.Size = new System.Drawing.Size(108, 28);
            this.radUnknown.TabIndex = 6;
            this.radUnknown.TabStop = true;
            this.radUnknown.Text = "Unknown";
            this.radUnknown.UseVisualStyleBackColor = true;
            this.radUnknown.CheckedChanged += new System.EventHandler(this.radUnknown_CheckedChanged);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(12, 169);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(77, 24);
            this.lblBirthday.TabIndex = 7;
            this.lblBirthday.Text = "Birthday";
            this.lblBirthday.Click += new System.EventHandler(this.Label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(316, 29);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioFemales
            // 
            this.radioFemales.AutoSize = true;
            this.radioFemales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemales.Location = new System.Drawing.Point(241, 121);
            this.radioFemales.Name = "radioFemales";
            this.radioFemales.Size = new System.Drawing.Size(101, 28);
            this.radioFemales.TabIndex = 10;
            this.radioFemales.TabStop = true;
            this.radioFemales.Text = "Females";
            this.radioFemales.UseVisualStyleBackColor = true;
            this.radioFemales.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(146, 121);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(69, 28);
            this.radMale.TabIndex = 9;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            this.radMale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 216);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 24);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(146, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 29);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(146, 310);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 29);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(146, 358);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(316, 29);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 408);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 456);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(316, 28);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(146, 505);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(316, 28);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblBirthplace
            // 
            this.lblBirthplace.AutoSize = true;
            this.lblBirthplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthplace.Location = new System.Drawing.Point(12, 264);
            this.lblBirthplace.Name = "lblBirthplace";
            this.lblBirthplace.Size = new System.Drawing.Size(93, 24);
            this.lblBirthplace.TabIndex = 18;
            this.lblBirthplace.Text = "Birthplace";
            this.lblBirthplace.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Current living";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupation.Location = new System.Drawing.Point(12, 361);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(107, 24);
            this.lblOccupation.TabIndex = 20;
            this.lblOccupation.Text = "Occupation";
            this.lblOccupation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFather
            // 
            this.lblFather.AutoSize = true;
            this.lblFather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFather.Location = new System.Drawing.Point(12, 408);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(64, 24);
            this.lblFather.TabIndex = 21;
            this.lblFather.Text = "Father";
            this.lblFather.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMother
            // 
            this.lblMother.AutoSize = true;
            this.lblMother.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMother.Location = new System.Drawing.Point(16, 456);
            this.lblMother.Name = "lblMother";
            this.lblMother.Size = new System.Drawing.Size(69, 24);
            this.lblMother.TabIndex = 22;
            this.lblMother.Text = "Mother";
            this.lblMother.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSpouse
            // 
            this.lblSpouse.AutoSize = true;
            this.lblSpouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpouse.Location = new System.Drawing.Point(16, 505);
            this.lblSpouse.Name = "lblSpouse";
            this.lblSpouse.Size = new System.Drawing.Size(75, 24);
            this.lblSpouse.TabIndex = 23;
            this.lblSpouse.Text = "Spouse";
            this.lblSpouse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBackToHomePage
            // 
            this.btnBackToHomePage.BackColor = System.Drawing.Color.DarkGray;
            this.btnBackToHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHomePage.Location = new System.Drawing.Point(20, 567);
            this.btnBackToHomePage.Name = "btnBackToHomePage";
            this.btnBackToHomePage.Size = new System.Drawing.Size(176, 42);
            this.btnBackToHomePage.TabIndex = 24;
            this.btnBackToHomePage.Text = "Back to home page";
            this.btnBackToHomePage.UseVisualStyleBackColor = false;
            this.btnBackToHomePage.Click += new System.EventHandler(this.btnBackToHomePage_Click);
            // 
            // FormInputPersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(484, 639);
            this.Controls.Add(this.btnBackToHomePage);
            this.Controls.Add(this.lblSpouse);
            this.Controls.Add(this.lblMother);
            this.Controls.Add(this.lblFather);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBirthplace);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.radioFemales);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.radUnknown);
            this.Controls.Add(this.radDeceassed);
            this.Controls.Add(this.radLiving);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFullName);
            this.Name = "FormInputPersonalInformation";
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input personal information";
            this.Load += new System.EventHandler(this.FormInputPersonalInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radLiving;
        private System.Windows.Forms.RadioButton radDeceassed;
        private System.Windows.Forms.RadioButton radUnknown;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioFemales;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblBirthplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblFather;
        private System.Windows.Forms.Label lblMother;
        private System.Windows.Forms.Label lblSpouse;
        private System.Windows.Forms.Button btnBackToHomePage;
    }
}

