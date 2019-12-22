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
    public partial class FormStudentDatabaseManagement : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Student_database_Management;User ID=sa;Password=***********");

        public FormStudentDatabaseManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblBranch_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblSemYear_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIDStudent.Text = " ";
            txtStudentName.Text = " ";
            txtAddress.Text = " ";
            txtPhoneNumber.Text = " ";
            txtSemYear.Text = " ";
            cbbBranch.Text = "Select your subjects";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                String ID = txtIDStudent.Text.ToString();
                String name = txtStudentName.Text.ToString();
                String add = txtAddress.Text.ToString();

                String phone = txtPhoneNumber.Text.ToString();
                long iphone = Int64.Parse(phone);

                String sem = txtSemYear.Text.ToString();
                int isem = Int32.Parse(sem);

                String branch = cbbBranch.SelectedItem.ToString();
                //MessageBox.Show("ID: " + ID + ", name: " + name + ", address: " + add + ", phone: " + iphone + ", sem: " + isem + ", branch: " + branch);

                String qry = "Insert into student values('" + ID + "','" + name + "','" + add + "','" + iphone + "','" + isem + "','" + branch + "')";

                SqlCommand sc = new SqlCommand();
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                {
                    MessageBox.Show(i + "Student registered successfully: " + name);
                }
                else
                {
                    MessageBox.Show("Student not registered: ");
                }
            }
            catch (System.Exception exp)
            {
                MessageBox.Show("Error is " + exp.ToString());
            }             
        }

        private void txtIDStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblIDStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
