using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_26_11_2019.StudentManagement
{
    public partial class UpdateForm : Form
    {
        private int StudentId;
        private LogicLayer Business;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.StudentId = id;
            this.Business = new LogicLayer();
            this.Load += UpdateForm_Load;
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var student = this.Business.GetStudents(this.StudentId);

            this.cboClass.DataSource = this.Business.GetClasses();
            this.cboClass.DisplayMember = "Name";
            this.cboClass.ValueMember = "id";
            this.cboClass.SelectedValue = student.Class_id;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;
            var name = this.txtFullName.Text;
            var birthday = this.dtp.Value;
            var class_id = (int)this.cboClass.SelectedValue;

            this.Business.CreateStudent(code, name, birthday, class_id);
            MessageBox.Show("Create student successfully.");
            this.Close();
        }



    }
}
