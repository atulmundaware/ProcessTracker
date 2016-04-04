using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ptlogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Login a = new Login();
                a.Closed += (s, args) => this.Close();
                a.Show();
            }
            catch(Exception exc)
            {
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(button1_Click);
            aTimer.Interval = 4000;
            aTimer.Enabled = true;
        }

        private void progressPanel1_Click_1(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit or no?",
                               "My First Application",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
