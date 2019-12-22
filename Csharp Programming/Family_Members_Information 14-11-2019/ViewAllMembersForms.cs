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
    public partial class ViewAllMembersForms : Form
    {
        public ViewAllMembersForms()
        {
            InitializeComponent();
            this.Load += ViewAllMembersForms_Load;
        }

        private void ViewAllMembersForms_Load(object sender, EventArgs e)
        {
            this.ViewAllMembers();
;       }
        private void ViewAllMembers()
        {
            var db = new OOP
            var members = db.members.ToArray();
            this.grdMembers.DataSource = members;
        }
    }
}
