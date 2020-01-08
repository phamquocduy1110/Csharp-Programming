using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Data;
using System.Data.SqlClient;

namespace Insert_Update_Delete_View_Search_in_Csharp_SQL_Server_Database__18_11_2019
{
    public partial class HomePageForm : Form
    {
        //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Student_database_Management;User ID=sa;Password=***********");

        public HomePageForm()
        {
            InitializeComponent();
            this.btnExit.Click += BtnExit_Click;
            this.btnClear.Click += btnClear_Click;
            this.btnNew.Click += BtnNew_Click;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var btnNew = new CreateNewStudentForm();
            btnNew.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            try
            {
                Exit = MessageBox.Show("Do you want to Exit? Confirm if you want to Exit.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(Exit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("System error! Please check it again", ex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDStudent.Text = "";
            txtStudentName.Text = "";
            txtGender.Text = "";
            dtpBirthdate.Text = "";
            txtPhoneNumber.Text = "";
            cbbClass.Text = "Select your class";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }
    }
}
