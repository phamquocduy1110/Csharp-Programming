using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_All_Members_25_11_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnViewAllMembers.Click += btnViewAllMembers_Click;
            this.btnExit.Click += btnExit_Click;
        }
                 
        private void btnViewAllMembers_Click(object sender, EventArgs e)
        {
            var Form1 = new View_all_members_form();
            Form1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            try
            {
                Exit = MessageBox.Show("Are you sure to exit? Confirm if you want to perform", "Exit Form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (Exit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("System error! Please check it again", ex);
            }
        }
    }
}
