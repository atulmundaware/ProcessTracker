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
    public partial class production : Form
    {
        String fgd;
        string myconnectionstring = "Server=192.168.198.193;Database=fgd;user=root;password=rootPass ;";

        public production()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            
           
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton10_Click(object sender, EventArgs e)
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
            sqlCmd.CommandText = "select po,stock,mcp,marking,production,pp,stock from fgd where fgd='" + fgd + "'";

            try
            {
                con.Open();

                MySqlDataReader read = sqlCmd.ExecuteReader();
                while (read.Read())
                {

                    textBox10.Text = read[0].ToString();
                    textBox2.Text = read[1].ToString();
                    textBox24.Text = read[2].ToString();
                    textBox23.Text = read[3].ToString();
                    textBox20.Text = read[4].ToString();
                    textBox19.Text = read[5].ToString();
                    textBox17.Text = read[6].ToString();



                    if (textBox24.Text.Length>1)
                    {
                        button3.Visible = false;
                    }

                    if (textBox24.Text.Equals("0"))
                    {
                        button3.Enabled = false;
                    }

                    if (textBox24.Text.Equals("1"))
                    {
                        button3.Enabled = true;
                    }


                    if (textBox23.Text.Length>1)
                    {
                        button4.Visible = false;
                    }

                    if (textBox23.Text.Equals("0"))
                    {
                        button4.Enabled = false;
                    }
                    if (textBox23.Text.Equals("1"))
                    {
                        button4.Enabled = true;
                    }


                    if (textBox20.Text.Length>1)
                    {
                        button5.Visible = false;
                    }

                    if (textBox20.Text.Equals("0"))
                    {
                        button5.Enabled = false;
                    }


                    if (textBox19.Text.Length>1)
                    {
                        button6.Visible = false;
                    }

                    if (textBox19.Text.Equals("0"))
                    {
                        button6.Enabled = false;
                    }
                    if (textBox19.Text.Equals("1"))
                    {
                        button6.Enabled = true;
                    }


                    if (textBox17.Text.Length>1)
                    {
                        button7.Visible = false;
                    }

                    if (textBox17.Text.Equals("0"))
                    {
                        button7.Enabled = false;
                    }
                    if (textBox17.Text.Equals("1"))
                    {
                        button7.Enabled = true;
                    }

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }

        }
        


        private void button3_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox24.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set mcp='" + textBox24.Text + "', mttp='1' where fgd='" + fgd + "' ";
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

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox23.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set marking='" + textBox23.Text + "', pp='1' where fgd='" + fgd + "' ";
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

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox20.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set production='" + textBox20.Text + "', marking='1' where fgd='" + fgd + "' ";
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

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox19.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set pp='" + textBox19.Text + "', qc='1' where fgd='" + fgd + "' ";
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

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox17.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set stock='" + textBox17.Text + "', invoice='1' where fgd='" + fgd + "' ";
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

        private void button2_Click(object sender, EventArgs e)
        {
            FGDStatus viewall = new FGDStatus();
            //  viewall.Closed += (s, args) => this.Close();
            viewall.Show();
        }

        private void production_Load(object sender, EventArgs e)
        {

        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button8_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Statuspro status1 = new Statuspro();
            //  viewall.Closed += (s, args) => this.Close();
            status1.Show();
        }
    }
}
