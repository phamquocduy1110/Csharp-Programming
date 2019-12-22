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
    public partial class CreateForm : Form
    {
        private LogicLayer Business;
        public CreateForm()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.Load += CreateForm_Load;
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The process is being performed! Are you sure to cancel, confirm if you want to cancel", "System warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            this.Close();    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;   
            var name = this.txtFullName.Text;
            var birthday = this.dtp.Value;
            var class_id = (int)this.cboClass.SelectedValue;

            this.Business.CreateStudent(code, name, birthday, class_id);
            MessageBox.Show("Create student successfully.");
            this.Close();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            this.cboClass.DataSource = this.Business.GetClasses();
            this.cboClass.DisplayMember = "Name";
            this.cboClass.ValueMember = "id";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
