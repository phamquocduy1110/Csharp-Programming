using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Members_Information_14_11_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void btnViewAllMembers_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            var form = new ViewAllMembersForms();
            form.ShowDialog();
        }
    }
}
