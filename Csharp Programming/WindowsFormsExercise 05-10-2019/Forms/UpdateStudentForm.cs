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
    public partial class UpdateStudentForm : Form
    {
        private int StudentID;
        private StudentManagement Business;
        public UpdateStudentForm(int id)
        {
            InitializeComponent();
            this.StudentID = id;
            this.Business = new StudentManagement();
            this.Load += UpdateStudentForm_Load;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnClear.Click += BtnClear_Click;
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            var oldClass = this.Business.GetClass(this.StudentID);
            this.txtCode.Text = oldClass.Code.ToString();
            this.txtFullName.Text = oldClass.Fullname;
            if (oldClass.Gender == true)
            {
                this.rdFemale.Checked = true;
            }
            else
            {
                this.rdMale.Checked = true;
            }
            this.dtpBirthdate.Value = (DateTime)oldClass.Birthday;
            this.txtPhoneNumber.Text = oldClass.PhoneNumber.ToString();
            //this.cbbClass = oldClass.Class.Sel;
            this.txtEmail.Text = oldClass.Email;
            this.txtAddress.Text = oldClass.LivingAddress;
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var code = int.Parse(this.txtCode.Text);
            var fullname = this.txtFullName.Text;
            bool gender = true; //female is true
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
            var @class = this.cbbClass.SelectedItem.ToString();
            var email = this.txtEmail.Text;
            var livingaddress = this.txtAddress.Text;
            this.Business.EditClass(this.StudentID, code, fullname, gender, birthdate, phonenumber, @class, email, livingaddress);
            MessageBox.Show("Update student successfully.");
        }
    }
}
