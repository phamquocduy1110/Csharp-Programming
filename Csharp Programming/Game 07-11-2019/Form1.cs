using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_07_11_2019
{
    public partial class Form1 : Form
    {
        Timer Timer = new Timer();
         
        public Form1()
        {
            InitializeComponent();
            Timer.Interval = 1000 / 24;
            Timer.Tick += Timer_Tick;
            //Timer.Start();
            this.button1.Click += button1_Click;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int delta = 10;
            int x = this.button1.Location.X;
            int y = this.button1.Location.Y;
            switch (e.KeyCode)
            {
                case Keys.W:
                    this.button1.Location = new Point(x, y - delta);
                    break;
                case Keys.S:
                    this.button1.Location = new Point(x, y + delta);
                    break;
                case Keys.A:
                    this.button1.Location = new Point(x - delta, y);
                    break;
                case Keys.D:
                    this.button1.Location = new Point(x + delta, y);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Timer.Stop();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                int x = this.button1.Location.X;
                int y = this.button1.Location.Y;
                this.button1.Location = new Point(x, y + 10);
                if (y > 1000)
                {
                    Random random = new Random();
                    x = random.Next(this.Width);
                    this.button1.Location = new Point(x, 0);
                }
            }
        }
    }
}
