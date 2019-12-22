namespace Dishes_Database_Management_12_10_2019
{
    partial class ListBreakfastForm
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
            this.GRDBreakfasts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GRDBreakfasts)).BeginInit();
            this.SuspendLayout();
            // 
            // GRDBreakfasts
            // 
            this.GRDBreakfasts.AllowUserToAddRows = false;
            this.GRDBreakfasts.AllowUserToDeleteRows = false;
            this.GRDBreakfasts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.GRDBreakfasts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRDBreakfasts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRDBreakfasts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GRDBreakfasts.Location = new System.Drawing.Point(0, 0);
            this.GRDBreakfasts.Name = "GRDBreakfasts";
            this.GRDBreakfasts.ReadOnly = true;
            this.GRDBreakfasts.Size = new System.Drawing.Size(800, 450);
            this.GRDBreakfasts.TabIndex = 0;
            this.GRDBreakfasts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRDBreakfasts_CellContentClick);
            // 
            // ListBreakfastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GRDBreakfasts);
            this.Name = "ListBreakfastForm";
            this.Text = "List all breakfasts dishes ";
            ((System.ComponentModel.ISupportInitialize)(this.GRDBreakfasts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GRDBreakfasts;
    }
}

