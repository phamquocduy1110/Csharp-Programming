using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_All_Members_25_11_2019
{
    public partial class View_all_members_form : Form
    {
        public View_all_members_form()
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
            var db = new FamilyMembersManagementEntities();
            var members = db.members.ToArray();
            var memberView = new MemberView[members.Length];
            for (int i = 0; i < members.Length; i++)
            {
                memberView[i] = new MemberView(members[i]);
            }
            this.dataGridView1.DataSource = memberView;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            try
            {
                Exit = MessageBox.Show("The process is being performed! Confirm if you want to exit", "System warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(Exit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("System error! Please check again", ex);
            }
        }
    }
}
