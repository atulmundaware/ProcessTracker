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
    public partial class store : Form
    {
        String fgd;
        string myconnectionstring = "Server=localhost;Database=fgd;user=root;password= rootPass;";

        public store()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox23.Text = time.ToString(format);
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox22.Text = time.ToString(format);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox21.Text = time.ToString(format);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox20.Text = time.ToString(format);
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox19.Text = time.ToString(format);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox18.Text = time.ToString(format);
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox17.Text = time.ToString(format);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox5.Text = time.ToString(format);
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
            sqlCmd.CommandText = "select co,po,mttv,stock,grn1,mttp,cpo,grn2,mis,cpr,ttv,invoice from fgd where fgd='" + fgd + "'";

            try
            {
                con.Open();

                MySqlDataReader read = sqlCmd.ExecuteReader();
                while (read.Read())
                {
                 //   MessageBox.Show(read[7].ToString);
                    textBox24.Text = read[0].ToString();
                    textBox10.Text = read[1].ToString();
                    textBox3.Text = read[2].ToString();
                    textBox2.Text = read[3].ToString();
                    textBox4.Text = read[4].ToString();
                    textBox23.Text = read[5].ToString();
                    textBox22.Text = read[6].ToString();
                    textBox21.Text = textBox3.Text; 
                    textBox20.Text = read[8].ToString();
                    textBox19.Text = read[9].ToString();
                    textBox18.Text = read[10].ToString();
                    textBox5.Text = read[11].ToString();
                    textBox6.Text = read[7].ToString();
                    textBox17.Text = read[3].ToString();


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

                    if (textBox22.Text.Length>1)
                    {
                        // MessageBox.Show("Data " + textBox23.Text);
                        button5.Visible = false;
                    }

                    if (textBox22.Text.Equals("0"))
                    {
                        // MessageBox.Show("Data " + textBox23.Text);
                        button5.Enabled = false;
                    }


                    if (textBox21.Text.Length>1)
                    {
                        // MessageBox.Show("Data " + textBox23.Text);
                        button6.Visible = false;
                    }

                    if (textBox21.Text.Equals("0"))
                    {
                        // MessageBox.Show("Data " + textBox23.Text);
                        button6.Enabled = false;
                    }

                    if (textBox22.Text.Equals("1"))
                    {
                        // MessageBox.Show("Data " + textBox23.Text);
                        button5.Enabled = true;
                    }


                    if (textBox20.Text.Length>1)
                    {
                        button7.Visible = false;
                    }


                    if (textBox20.Text.Equals("0"))
                    {
                        button7.Enabled = false;
                    }
                    if (textBox20.Text.Equals("1"))
                    {
                        button7.Enabled = true;
                    }



                    if (textBox19.Text.Length>1)
                    {
                        button8.Visible = false;
                    }

                    if (textBox19.Text.Equals("0"))
                    {
                        button8.Enabled = false;
                    }
                    if (textBox19.Text.Equals("1"))
                    {
                        button8.Enabled = true;
                    }


                    if (textBox18.Text.Length>1)
                        button9.Visible = false;

                    if (textBox18.Text.Equals("0"))
                        button9.Enabled = false;

                    if (textBox18.Text.Equals("1"))
                        button9.Enabled = true;


                    if (textBox5.Text.Length>1)
                        button10.Visible = false;

                    if (textBox5.Text.Equals("0"))
                        button10.Enabled = false;
                    if (textBox5.Text.Equals("1"))
                        button10.Enabled = true;
                    
                    if (textBox17.Text.Length>1)
                        button11.Visible = false;
                    if (textBox21.Text.Equals("1"))
                        button6.Enabled = true;


                    if (textBox17.Text.Equals("0"))
                        button11.Enabled = false;
                    if (textBox17.Text.Equals("1"))
                        button11.Enabled = true;


                    if (textBox6.Text.Length>1)
                        button12.Visible = false;

                    if (textBox6.Text.Equals("0"))
                        button12.Enabled = false;
                    if (textBox6.Text.Equals("1"))
                        button12.Enabled = true;

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
            textBox4.Text = time.ToString(format);



            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set grn1='" + textBox4.Text + "', mis='1' where fgd='" + fgd + "' ";
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
            textBox20.Text = time.ToString(format);
            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set mis='" + textBox20.Text + "', mcp='1' where fgd='" + fgd + "' ";
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
            String query = "update fgd set mttp='" + textBox23.Text + "', production='1' where fgd='" + fgd + "' ";
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

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox19.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set cpr='" + textBox19.Text + "', cpo='1' where fgd='" + fgd + "' ";
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
            textBox22.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set cpo='" + textBox22.Text + "', ttv='1' where fgd='" + fgd + "' ";
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
            textBox21.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set mttv='" + textBox21.Text + "', gav='1' where fgd='" + fgd + "' ";
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

        private void button9_Click(object sender, EventArgs e)
        {
            

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox18.Text = time.ToString(format);


            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set ttv='" + textBox18.Text + "', casee='1' where fgd='" + fgd + "' ";
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

        private void button10_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox5.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set invoice='" + textBox5.Text + "' where fgd='" + fgd + "' ";
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

        private void button11_Click(object sender, EventArgs e)
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

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FGDStatus viewall = new FGDStatus();
            //  viewall.Closed += (s, args) => this.Close();
            viewall.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login p = new Login();
            p.Closed += (s, args) => this.Close();
            p.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox6.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set grn2='" + textBox6.Text + "', stock='1' where fgd='" + fgd + "' ";
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

        private void button13_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Statusst status3 = new Statusst();
            //  viewall.Closed += (s, args) => this.Close();
            status3.Show();
        }
    }
}
