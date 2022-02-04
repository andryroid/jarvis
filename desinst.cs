using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace jarvis
{
    public partial class desinst : Form
    {
        public desinst()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        public void desinst_Load(object sender, EventArgs e)
        {
            string chemin = @"C:\Program Files (x86)";
            string chemin2;
            foreach (string di in Directory.GetDirectories(chemin))
            {
                chemin2 = di;
                foreach (string dii in Directory.GetFiles(chemin2))
                {
                    if (dii.Contains("unins") && dii.Contains(".exe"))
                    {
                        listBox5.Items.Add(maka2(maka(dii)));
                    }
                }
            }
        }
        private bool exist(ListBox li,string test) {
            bool t = false;
            for (int i=0;i<li.Items.Count;i++) {
                if (test == li.Items[i].ToString()) {
                    t = true;
                }
            }
            return t;
        }
        private string maka(string s)
        {
            string fin = null;
            for (int i = 23; i < s.Length; i++)
            {
                fin += s[i];
            }
            return fin;
        }
        private string maka2(string s)
        {
            int x = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '\\')
                {
                    x = i;
                    break;
                }
            }
            string farany = "";
            for (int i = 0; i < x; i++)
            {
                farany += s[i];
            }
            return farany;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = jarvis.Properties.Resources.quitterD;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = jarvis.Properties.Resources.bfermar;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string chemin = @"C:\Program Files (x86)";
                string chemin2;
                foreach (string di in Directory.GetDirectories(chemin))
                {
                    chemin2 = di;
                    foreach (string dii in Directory.GetFiles(chemin2))
                    {
                        if (dii.Contains("" + listBox5.Items[listBox5.SelectedIndex]))
                        {
                            Process.Start(dii);
                        }
                    }
                }
            }
            catch { }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.desD2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.des;
        }
    }
    
}
