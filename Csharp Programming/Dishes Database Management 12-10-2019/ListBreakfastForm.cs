using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dishes_Database_Management_12_10_2019
{
    public partial class ListBreakfastForm : Form
    {
        public ListBreakfastForm()
        {
            InitializeComponent();
            this.Load += ListBreakfastForm_Load;
        }

        private void ListBreakfastForm_Load(object sender, EventArgs e)
        {
            this.ShowBreakfastDishes();
        }

        private void ShowBreakfastDishes()
        {
            var db = new RestaurantEnitities();
            var list = db.Breakfasts.ToArray();
            this.GRDBreakfasts.DataSource = list;
        }

        private void GRDBreakfasts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
