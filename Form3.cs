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

namespace jarvis
{
    public partial class Form3 : Form
    {
        static int oi = 0;
        //Form1 f1;
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox10_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox11_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.1;
            }
            else
                timer1.Enabled = false;
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = jarvis.Properties.Resources.accueilD;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = jarvis.Properties.Resources.baccueil;
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = jarvis.Properties.Resources.favorisD;
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = jarvis.Properties.Resources.bfavoris;
        }

        private void pictureBox3_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = jarvis.Properties.Resources.extrasD;
        }

        private void pictureBox3_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = jarvis.Properties.Resources.bextras;
        }

        private void pictureBox4_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = jarvis.Properties.Resources.maintananceD;
        }

        private void pictureBox4_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = jarvis.Properties.Resources.bmaintenance;
        }

        private void pictureBox5_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = jarvis.Properties.Resources.sécuritéD;
        }

        private void pictureBox5_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = jarvis.Properties.Resources.bsécurité;
        }

        private void pictureBox6_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = jarvis.Properties.Resources.aproposD;
        }

        private void pictureBox6_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = jarvis.Properties.Resources.bapropos;
        }

        private void pictureBox10_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox10.BackgroundImage = jarvis.Properties.Resources.mic_activerD;
        }

        private void pictureBox10_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox10.BackgroundImage = jarvis.Properties.Resources.mic_activer;
        }

        private void pictureBox11_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox11.BackgroundImage = jarvis.Properties.Resources.mic_desactiverD;
        }

        private void pictureBox11_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox11.BackgroundImage = jarvis.Properties.Resources.mic_desactiver;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            oi = 0;
            pictureBox11.Enabled = false;
            pictureBox10.Enabled = true;
        }

        private void pictureBox8_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = jarvis.Properties.Resources.réduireD;
        }

        private void pictureBox8_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = jarvis.Properties.Resources.breduire;
        }

        private void pictureBox7_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = jarvis.Properties.Resources.quitterD;
        }

        private void pictureBox7_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = jarvis.Properties.Resources.bfermar;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = jarvis.Properties.Resources.parametreD;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = jarvis.Properties.Resources.parametres;
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.BackgroundImage = jarvis.Properties.Resources.aideD;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackgroundImage = jarvis.Properties.Resources.aide;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            timer2.Enabled = true;
        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else 
            {
                MAINTENANCE f4 = new MAINTENANCE();
                f4.Show();
                this.Hide();
                timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (oi == 5) { timer3.Enabled = false; Process.Start("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe"); oi = 0; }
            oi++;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\njiva\Desktop\jarvis 2.0 - B\CryptDir2010\CryptDir2010\bin\Release\CryptDir.exe");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\ProgramData\rvlkl\rvlkl.exe");
        }
    }
}
