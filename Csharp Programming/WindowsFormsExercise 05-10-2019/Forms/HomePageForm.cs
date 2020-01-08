using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExercise_05_10_2019.Forms;

namespace WindowsFormsExercise_05_10_2019
{
    public partial class HomePageForm : Form
    {
        private StudentManagement Business;
        public HomePageForm()
        {
            InitializeComponent();
            this.Business = new StudentManagement();
            this.Load += HomePageForm_Load;
            this.btnExit.Click += BtnExit_Click;
            this.btnClear.Click += btnClear_Click;
            this.btnNew.Click += BtnNew_Click;
            this.dataGridView1.DoubleClick += DataGridView1_DoubleClick;
            this.btnDelete.Click += BtnDelete_Click;
        }

        void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this? ", "Confirm",
                   MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var student = (LoadAllClasses)this.dataGridView1.SelectedRows[0].DataBoundItem;
                    this.Business.LoadAllClasses(student.id);
                    MessageBox.Show("Delete class successfully");
                    this.LoadAllClasses();
                }
            }
        }

        void HomePageForm_Load(object sender, EventArgs e)
        {
            this.LoadAllClasses();
        }

        private void LoadAllClasses()
        {
            var classes = this.Business.GetClass();
            this.dataGridView1.DataSource = classes;
        }

        void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                var @class = (Member)this.dataGridView1.SelectedRows[0].DataBoundItem;

                var updateForm = new UpdateStudentForm(@class.id);
                updateForm.ShowDialog();
                this.LoadAllClasses();
            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @class = (Member)this.dataGridView1.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteClass(@class.id);
                    MessageBox.Show("Delete class successfully.");
                    this.LoadAllClasses();
                }
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var btnNew = new CreateNewStudentForm();
            btnNew.ShowDialog();
            this.LoadAllClasses();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            try
            {
                Exit = MessageBox.Show("Do you want to Exit? Confirm if you want to Exit.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
