using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jarvis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                this.Close();
                timer1.Enabled = false;
            }
            else
            {
                progressBar1.Value += 1;
                this.Opacity += 0.01;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.progressBar1.Value==100 )
            {
                
                timer1.Enabled = false;
               timer2.Enabled = true;
                
            }
            else
            {
                progressBar1.Value += 1;
                this.Opacity += 0.1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (this.Opacity <= 0)
            {

                timer2.Enabled = false;
                this.Close();
            }
            else
            {
                this.Opacity -= 0.01;
            }
              
        }
    }
}
