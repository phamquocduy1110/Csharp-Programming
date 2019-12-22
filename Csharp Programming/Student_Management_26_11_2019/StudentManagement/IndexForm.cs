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

namespace Test_26_11_2019.StudentManagement
{
    public partial class IndexForm : Form
    {
        private LogicLayer Business;

        public object C { get; private set; }

        public IndexForm()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.Load += IndexForm_Load;
            this.btnCreate.Click += btnCreate_Click; 
            this.btnDelete.Click += btnDelete_Click;
            this.grdStudents.DoubleClick += grdStudents_DoubleClick;

        }

        private void ShowAllStudents()
        {
            //this.grdStudents.DataSource = this.Business.GetStudents();
            var students = this.Business.GetStudents();
            var studentViews = new StudentView[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                studentViews[i] = new StudentView(students[i]);
            }
                
            this.grdStudents.DataSource = studentViews;
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            this.ShowAllStudents();
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            var IndexForm = new CreateForm();
            IndexForm.ShowDialog();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdStudents.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var row = (Student)this.grdStudents.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteClass(row.id);
                    MessageBox.Show("Delete class successfully.");
                    this.ShowAllStudents();
                }
            }
        }

        void grdStudents_DoubleClick(object sender, EventArgs e)
        {
            if(grdStudents.SelectedRows.Count == 1)
            {
                var row = this.grdStudents.SelectedRows[0];
                var studentView = (StudentView)row.DataBoundItem;

                (new UpdateForm(studentView.id)).ShowDialog();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C# Programming\\Csharp Programming\\Test_26_11_2019\\MyDatabase.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("Select * FROM Insert Update Delete View Search in Csharp SQL Server Database  18-11-2019 where ID like" + int.Parse(textBox1.Text), con);
            SDA.Fill(dt);
            grdStudents.DataSource = dt;
        }
    }
}
