using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercise_05_10_2019.Forms
{
    public partial class CreateNewStudentForm : Form
    {
        private StudentManagement Business;
        public CreateNewStudentForm()
        {
            InitializeComponent();
            this.Business = new StudentManagement();
            this.btnAdd.Click += BtnAdd_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnClear.Click += BtnClear_Click;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtIDStudent.Text = "";
            txtFullName.Text = "";
            rdMale.Text = "";
            rdFemale.Text = "";
            dtpBirthdate.Text = "";
            txtPhoneNumber.Text = "";
            cbbClass.Text = "Select your class";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System warning! The process is being performed. Do you want to Cancel. Confirm if you want to Cancel?", "System warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var code = int.Parse(this.txtCode.Text);
            var fullname = this.txtFullName.Text;
            bool gender = true;
            if (rdMale.Checked == true)
            {
                gender = false;
            }
            else
            {
                gender = true;
            }
            var birthdate = this.dtpBirthdate.Value;
            var phonenumber = int.Parse(this.txtPhoneNumber.Text);
            var @Class = this.cbbClass.SelectedItem.ToString();
            var email = this.txtEmail.Text;
            var livingaddress = this.txtAddress.Text;

            this.Business.AddClass(code, fullname, gender, birthdate, phonenumber, @Class, email, livingaddress);
            MessageBox.Show("Add new class successfully.");
            this.Close();
        }
    }
}
