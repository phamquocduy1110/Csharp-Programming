using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAppForm_05_11_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnCompute.Click += btnCompute_Click;
        }

        void btnCompute_Click(object sender, EventArgs e)
        {
            int totalAmount = int.Parse(this.txtTotalAmount.Text);
            double taxPercentage = double.Parse(this.lblTaxPercentage.Text.Replace("%", ""));
            double totalDue = (taxPercentage / 100 + 1) *totalAmount;
            this.txtTotalDue.Text = totalDue.ToString();
        }

    }
}
