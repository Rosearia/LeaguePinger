using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaguePinger
{
    public partial class LeaguePinger : Form
    {
        public LeaguePinger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ping ping = new Ping();
                PingReply pingresult = ping.Send("4.2.2.2", 1000);
                if (pingresult.Status.ToString() == "Success")
                {
                    button1.Text = pingresult.RoundtripTime.ToString() + " ms";
                    pictureBox1.Image = Properties.Resources.status_o;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.status_d;
                }

            }
            catch
            {
                MessageBox.Show("Sorry, there was an error.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pingAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
