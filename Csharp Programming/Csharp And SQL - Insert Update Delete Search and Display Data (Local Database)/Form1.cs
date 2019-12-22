using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Csharp_And_SQL___Insert_Update_Delete_Search_and_Display_Data__Local_Database_
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Server1;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [MyStudentManagementTable] (Name, Surname, Address) values ('" + txtName.Text + "', '" + txtSurname + "', '" + txtAddress + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            txtName.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
            display_data();
            MessageBox.Show("Data inserted successfully");
        }

        // To display Data

        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [MyStudentManagementTable]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [MyStudentManagementTable] where name = '" + txtName.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            txtName.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
            display_data();
            MessageBox.Show("Data deleted successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [MyStudentManagementTable] set name = '" + txtSurname.Text + "' where name = '" + txtName.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            txtName.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
            display_data();
            MessageBox.Show("Data update successfully");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [MyStudentManagementTable] where name = '" + txtSearch.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            txtName.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
        }
    }
}
        
