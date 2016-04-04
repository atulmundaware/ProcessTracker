using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ptlogin
{
    public partial class qc : Form
    {
        String fgd;
        string myconnectionstring = "Server=localhost;Database=fgd;user=root;password= rootPass;";
        public qc()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
            fgd = textBox1.Text;
            reload();
        }



        public void reload()
        {

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            MySqlCommand sqlCmd = con.CreateCommand();
            sqlCmd.CommandText = "select qc,stock from fgd where fgd='" + fgd + "'";

            try
            {
                con.Open();

                MySqlDataReader read = sqlCmd.ExecuteReader();
                while (read.Read())
                {

                    textBox4.Text = read[0].ToString();
                    textBox2.Text = read[1].ToString();


                    if (textBox4.Text.Length>1)
                    {
                        button3.Visible = false;
                    }


                    if (textBox4.Text.Equals("0"))
                    {
                        button3.Enabled = false;
                    }
                    if (textBox4.Text.Equals("1"))
                    {
                        button3.Enabled = true;
                    }

              }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }

        }

           
        private void button2_Click(object sender, EventArgs e)
        {
            FGDStatus viewall = new FGDStatus();
            //  viewall.Closed += (s, args) => this.Close();
            viewall.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox4.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set qc='" + textBox4.Text + "', cpr='1' where fgd='" + fgd + "' ";
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login p = new Login();
            p.Closed += (s, args) => this.Close();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Statusqc status2 = new Statusqc();
            //  viewall.Closed += (s, args) => this.Close();
            status2.Show();
        }
        }
    }

