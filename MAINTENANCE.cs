using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Diagnostics;
namespace jarvis
{
    public partial class MAINTENANCE : Form
    {
        public MAINTENANCE()
        {
            InitializeComponent();
        }

        private void MAINTENANCE_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.1;

            }
            else {
                timer1.Enabled = false;
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = jarvis.Properties.Resources.defragD;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = jarvis.Properties.Resources.defrag;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = jarvis.Properties.Resources.recuD1;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = jarvis.Properties.Resources.recu1;
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.BackgroundImage = jarvis.Properties.Resources.accueilD;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.BackgroundImage = jarvis.Properties.Resources.baccueil;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = jarvis.Properties.Resources.favorisD;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = jarvis.Properties.Resources.bfavoris;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = jarvis.Properties.Resources.extrasD;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = jarvis.Properties.Resources.bextras;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = jarvis.Properties.Resources.maintananceD;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = jarvis.Properties.Resources.bmaintenance;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = jarvis.Properties.Resources.sécuritéD;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = jarvis.Properties.Resources.bsécurité;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = jarvis.Properties.Resources.aproposD;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = jarvis.Properties.Resources.bapropos;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.BackgroundImage = jarvis.Properties.Resources.instaD;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.BackgroundImage = jarvis.Properties.Resources.insta;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Users\njiva\Desktop\jarvis 2.0 - B\53923-1365298-defragmenter-un-fichier\bin\Defrag.exe");
            }
            catch { }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    desinst ds = new desinst();
            //    string chemin = @"C:\Program Files (x86)";
            //    string chemin2;
            //    foreach(string di in Directory.GetDirectories(chemin))
            //    { 
            //        chemin2 = di;
            //        foreach (string dii in Directory.GetFiles(chemin2)) {
            //            if (dii.Contains("unins")) {
            //                ds.listBox5.Items.Add(maka2(maka(dii)));
            //            }  
            //        }
            //     }
            //    ds.Show();
            //}
            //catch { }
            desinst desin = new desinst();
            desin.desinst_Load(this, e);
            desin.Show();
            
        }
        private string maka(string s) {
            string fin = null ;
            for (int i = 23; i < s.Length; i++) {
                fin += s[i];
            }
            return fin;
        }
        private string maka2(string s) {
            int x = 0;
            for (int i = s.Length - 1; i >= 0; i--) {
                if (s[i] == '\\') {
                    x = i;
                    break;
                }
           }
            string farany = "";
            for (int i = 0; i < x; i++) {
                farany += s[i];
            }
            return farany;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Visible = false; label3.Visible = false;
            button3.Enabled = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox10.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            //pictureBox13.Visible = false;
            string chemin = @"C:\Program Files (x86)";
            string[] fichier = Directory.GetDirectories(chemin);
            foreach (string x in fichier)
            {
                listBox1.Items.Add(x);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            int x = listBox1.SelectedIndex;
            string mot = "" + listBox1.Items[x];
            string motfin = "";
            for (int k = 23; k < mot.Length; k++)
            {
                motfin += mot[k];
            }
            listBox2.Items.Add(motfin);
            listBox1.SelectedIndex = -1;
            listBox1.Items.RemoveAt(x);
        }

        private void listBox3_Click(object sender, EventArgs e)
        {
            int x = listBox1.SelectedIndex;
            string mot = "" + listBox1.Items[x];
            string motfin = "";
            for (int k = 23; k < mot.Length; k++)
            {
                motfin += mot[k];
            }
            listBox2.Items.Add(motfin);
            listBox1.SelectedIndex = -1;
            listBox1.Items.RemoveAt(x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            groupBox1.Visible = true;
            groupBox1.Width = 480;
            groupBox1.Height = 290;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button1.Visible = false;
            button2.Visible = false;
            groupBox2.Visible = true;
            groupBox2.Location = new Point(groupBox1.Location.X, groupBox1.Location.Y);
            groupBox2.Width = 480;
            groupBox2.Height = 290;

            Process[] p = Process.GetProcesses();
            foreach (Process pr in p)
            {
                listBox3.Items.Add(pr.ProcessName);
                listBox4.Items.Add(pr.BasePriority);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\njiva\Desktop\jarvis 2.0 - B\CryptDir2010\CryptDir2010\bin\Release\CryptDir.exe");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:\\Program Files\\Recuva\\Recuva.exe");
            }
            catch { }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\ProgramData\rvlkl\rvlkl.exe");
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = jarvis.Properties.Resources.quitterD;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = jarvis.Properties.Resources.bfermar;
        }
    }
}
