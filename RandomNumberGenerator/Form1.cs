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
/*Oğuzhan Taşımaz 2018 TR  */

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(richTextBox1.Text);
            int j = int.Parse(richTextBox2.Text);
            j++;
            Random randomabc = new Random();
            MessageBox.Show(randomabc.Next(i,j).ToString());


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = pictureBox2.Height;
            sidepanel.Top = pictureBox2.Top;
            Process.Start("https://www.twitch.tv/canko");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = pictureBox4.Height;
            sidepanel.Top = pictureBox4.Top;
            Process.Start("https://www.instagram.com/cankoatasev/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = pictureBox3.Height;
            sidepanel.Top = pictureBox3.Top;
            Process.Start("https://www.facebook.com/Cankodota");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = pictureBox5.Height;
            sidepanel.Top = pictureBox5.Top;
            Process.Start("https://twitter.com/Cankodota");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bynogame.com/store/canko");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("http://ymk.st/canko");
;        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğine emin misin?", "Çıkışı Onayla", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                
            }
            else
            {
                this.Close();
            }
        }

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CekilisKazananlar.txt");
           
            TextWriter writer = new StreamWriter(path);
            writer.Write(richTextBox3.Text);
            writer.Close();
            
        }
    }
}
