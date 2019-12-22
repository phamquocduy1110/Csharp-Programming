using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercise_05_10_2019
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
            this.llblAddNewStudent.Click += LlblAddNewStudent_Click;
            this.llblExit.Click += LlblExit_Click;
        }

        private void LlblAddNewStudent_Click(object sender, EventArgs e)
        {
            var llblAddNewStudent = new AddNewStudentForm();
            llblAddNewStudent.ShowDialog();
        }

        private void LlblExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            try
            {
                Exit = MessageBox.Show("Are you sure want to Exit? Confirm if you want to Exit", "Exit form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
