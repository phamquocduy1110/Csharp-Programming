using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ViewAllMembersForm : Form
    {
        public ViewAllMembersForm()
        {
            InitializeComponent();
            this.Load += ViewAllMembersForm_Load;
            
        }

        void ViewAllMembersForm_Load(object sender, EventArgs e)
        {
            this.ViewAllMembers();
        }

        private void ViewAllMembers()
        {
            var db = new OOPCSEntities();
            var members = db.Members.ToArray();
            var memberView = new MemberView[members.Length];
            for (int i = 0; i < members.Length; i++ )
            {
                memberView[i] = new MemberView(members[i]);
            }
            this.grdMembers.DataSource = memberView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
