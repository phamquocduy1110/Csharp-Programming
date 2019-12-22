namespace Family_Members_Information_14_11_2019
{
    partial class Home_Page
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAllMembersFamily = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 549);
            this.label1.TabIndex = 0;
            // 
            // btnViewAllMembersFamily
            // 
            this.btnViewAllMembersFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnViewAllMembersFamily.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnViewAllMembersFamily.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnViewAllMembersFamily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnViewAllMembersFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllMembersFamily.ForeColor = System.Drawing.Color.White;
            this.btnViewAllMembersFamily.Location = new System.Drawing.Point(49, 88);
            this.btnViewAllMembersFamily.Name = "btnViewAllMembersFamily";
            this.btnViewAllMembersFamily.Size = new System.Drawing.Size(189, 49);
            this.btnViewAllMembersFamily.TabIndex = 1;
            this.btnViewAllMembersFamily.Text = "View all members family";
            this.btnViewAllMembersFamily.UseVisualStyleBackColor = false;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 549);
            this.Controls.Add(this.btnViewAllMembersFamily);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Home_Page";
            this.Text = "Home_Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAllMembersFamily;
    }
}