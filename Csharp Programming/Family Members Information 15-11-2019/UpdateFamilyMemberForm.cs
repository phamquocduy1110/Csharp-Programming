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
    public partial class UpdateFamilyMemberForm : Form
    {
        private int ClassId;
        private Family_Members_Management Business;
        public UpdateFamilyMemberForm(int id)
        {
            InitializeComponent();
            this.ClassId = id;
            //this.Business = new FamilyMembersManagementEntities();
            this.btnAdd.Click += btnAdd_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.Load += UpdateClassForm_Load;
        }

        void UpdateClassForm_Load(object sender, EventArgs e)
        {
            var oldClass = this.Business.GetClass(this.ClassId);
            this.txtFullname.Text = oldClass.fullname;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The process is being performed! Comfirm if you want to Cancel", "System warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            this.Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            
            var fullname = this.txtFullname.Text;
            var hometown = this.txtBirthplace.Text;
            var currentliving = this.txtCurrentliving.Text;
            var occupation = this.txtOccupation.Text;
            
            
            this.Business.EditClass(this.ClassId, fullname, hometown, currentliving, occupation);
            MessageBox.Show("Update class successfully.");
        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
