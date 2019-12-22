namespace BMI_Calculator_07_11_2019
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
            this.lbl_BMI_CALCULATOR_METRIC = new System.Windows.Forms.Label();
            this.lbl_YourHeight = new System.Windows.Forms.Label();
            this.txt_centimeters = new System.Windows.Forms.TextBox();
            this.lbl_centimeters = new System.Windows.Forms.Label();
            this.lbl_kilograms = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_YourWeight = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_YourBMI = new System.Windows.Forms.Label();
            this.txt_YourBMI = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_BMI_CALCULATOR_METRIC
            // 
            this.lbl_BMI_CALCULATOR_METRIC.AutoSize = true;
            this.lbl_BMI_CALCULATOR_METRIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lbl_BMI_CALCULATOR_METRIC.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BMI_CALCULATOR_METRIC.ForeColor = System.Drawing.Color.White;
            this.lbl_BMI_CALCULATOR_METRIC.Location = new System.Drawing.Point(12, 25);
            this.lbl_BMI_CALCULATOR_METRIC.Name = "lbl_BMI_CALCULATOR_METRIC";
            this.lbl_BMI_CALCULATOR_METRIC.Size = new System.Drawing.Size(316, 31);
            this.lbl_BMI_CALCULATOR_METRIC.TabIndex = 1;
            this.lbl_BMI_CALCULATOR_METRIC.Text = "BMI CALCULATOR METRIC";
            this.lbl_BMI_CALCULATOR_METRIC.Click += new System.EventHandler(this.Lbl_METRIC_Click);
            // 
            // lbl_YourHeight
            // 
            this.lbl_YourHeight.AutoSize = true;
            this.lbl_YourHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lbl_YourHeight.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YourHeight.ForeColor = System.Drawing.Color.White;
            this.lbl_YourHeight.Location = new System.Drawing.Point(29, 88);
            this.lbl_YourHeight.Name = "lbl_YourHeight";
            this.lbl_YourHeight.Size = new System.Drawing.Size(66, 42);
            this.lbl_YourHeight.TabIndex = 2;
            this.lbl_YourHeight.Text = "     Your\r\nHeight:";
            this.lbl_YourHeight.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txt_centimeters
            // 
            this.txt_centimeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_centimeters.Location = new System.Drawing.Point(155, 86);
            this.txt_centimeters.Name = "txt_centimeters";
            this.txt_centimeters.Size = new System.Drawing.Size(146, 44);
            this.txt_centimeters.TabIndex = 3;
            // 
            // lbl_centimeters
            // 
            this.lbl_centimeters.AutoSize = true;
            this.lbl_centimeters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lbl_centimeters.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_centimeters.ForeColor = System.Drawing.Color.Black;
            this.lbl_centimeters.Location = new System.Drawing.Point(151, 133);
            this.lbl_centimeters.Name = "lbl_centimeters";
            this.lbl_centimeters.Size = new System.Drawing.Size(127, 23);
            this.lbl_centimeters.TabIndex = 4;
            this.lbl_centimeters.Text = "(centimeters)";
            this.lbl_centimeters.Click += new System.EventHandler(this.Txt_centimeters_Click);
            // 
            // lbl_kilograms
            // 
            this.lbl_kilograms.AutoSize = true;
            this.lbl_kilograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lbl_kilograms.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kilograms.ForeColor = System.Drawing.Color.Black;
            this.lbl_kilograms.Location = new System.Drawing.Point(151, 231);
            this.lbl_kilograms.Name = "lbl_kilograms";
            this.lbl_kilograms.Size = new System.Drawing.Size(112, 23);
            this.lbl_kilograms.TabIndex = 7;
            this.lbl_kilograms.Text = "(kilograms)";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(155, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 44);
            this.textBox2.TabIndex = 6;
            // 
            // lbl_YourWeight
            // 
            this.lbl_YourWeight.AutoSize = true;
            this.lbl_YourWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lbl_YourWeight.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YourWeight.ForeColor = System.Drawing.Color.White;
            this.lbl_YourWeight.Location = new System.Drawing.Point(29, 186);
            this.lbl_YourWeight.Name = "lbl_YourWeight";
            this.lbl_YourWeight.Size = new System.Drawing.Size(70, 42);
            this.lbl_YourWeight.TabIndex = 5;
            this.lbl_YourWeight.Text = "     Your\r\nWeight:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(98, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Compute BMI";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_YourBMI
            // 
            this.lbl_YourBMI.AutoSize = true;
            this.lbl_YourBMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lbl_YourBMI.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YourBMI.ForeColor = System.Drawing.Color.Black;
            this.lbl_YourBMI.Location = new System.Drawing.Point(104, 370);
            this.lbl_YourBMI.Name = "lbl_YourBMI";
            this.lbl_YourBMI.Size = new System.Drawing.Size(129, 31);
            this.lbl_YourBMI.TabIndex = 9;
            this.lbl_YourBMI.Text = "Your BMI:";
            this.lbl_YourBMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_YourBMI.Click += new System.EventHandler(this.Lbl_YourBMI_Click);
            // 
            // txt_YourBMI
            // 
            this.txt_YourBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_YourBMI.Location = new System.Drawing.Point(98, 404);
            this.txt_YourBMI.Name = "txt_YourBMI";
            this.txt_YourBMI.Size = new System.Drawing.Size(146, 44);
            this.txt_YourBMI.TabIndex = 10;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(120, 491);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 38);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(343, 576);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_YourBMI);
            this.Controls.Add(this.lbl_YourBMI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_kilograms);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_YourWeight);
            this.Controls.Add(this.lbl_centimeters);
            this.Controls.Add(this.txt_centimeters);
            this.Controls.Add(this.lbl_YourHeight);
            this.Controls.Add(this.lbl_BMI_CALCULATOR_METRIC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_BMI_CALCULATOR_METRIC;
        private System.Windows.Forms.Label lbl_YourHeight;
        private System.Windows.Forms.TextBox txt_centimeters;
        private System.Windows.Forms.Label lbl_centimeters;
        private System.Windows.Forms.Label lbl_kilograms;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_YourWeight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_YourBMI;
        private System.Windows.Forms.TextBox txt_YourBMI;
        private System.Windows.Forms.Button btn_Exit;
    }
}

