using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Members_Information_15_11_2019
{
    public partial class FormAddNewMember : Form
    {
        private Family_Members_Management Business;
        public FormAddNewMember()
        {
            InitializeComponent();
            this.Business = new Family_Members_Management();
            this.btnAdd.Click += btnAdd_Click;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var fullname = this.txtFullName.Text;
            var hometown = this.txtHomeTown.Text;
            var currentliving = this.txtCurrentLiving.Text;
            var occupation = this.txtOccupation.Text;

            this.Business.AddClass(fullname, hometown, currentliving, occupation);
            MessageBox.Show("Add new class successfully.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The process is being performed! Comfirm if you want to Cancel", "System warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
