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
    public partial class vendor : Form
    {
        String fgd;
        string myconnectionstring = "Server=192.168.198.193;Database=fgd;user=root;password=rootPass;";

        public vendor()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox24.Text = time.ToString(format);
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

        private void button1_Click(object sender, EventArgs e)
        {

            fgd = textBox1.Text;
            reload();

        }


        public void reload()
        {

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            MySqlCommand sqlCmd = con.CreateCommand();
           // MessageBox.Show("1");
           // sqlCmd.CommandText = "select pr 4,gav 7,cpo 17,case 19,po 5,cpr16,ttv 18,stock 21 from fgd where fgd='"+ fgd +"'";   

            sqlCmd.CommandText = "select * from fgd where fgd='" + fgd + "'";

            try
            {
                con.Open();
               // MessageBox.Show("2");
                MySqlDataReader read = sqlCmd.ExecuteReader();
               // MessageBox.Show("3");
                while (read.Read())
                {

                    textBox24.Text = read[4].ToString();
                 //   MessageBox.Show("4");
                    textBox23.Text = read[7].ToString();
                   // MessageBox.Show("5");
                    textBox22.Text = read[17].ToString();
                    textBox21.Text = read[19].ToString();

                    textBox20.Text = read[5].ToString();
                    textBox19.Text = read[16].ToString();

                    textBox18.Text = read[18].ToString();
                    textBox17.Text = read[21].ToString();


                    if (textBox24.Text.Length>1)
                    {
                        button10.Visible = false;
                    }

                    if (textBox24.Text.Equals("0"))
                    {
                        button10.Enabled = false;
                    }
                    if (textBox24.Text.Equals("1"))
                    {
                        button10.Enabled = true;
                    }


                    if (textBox23.Text.Length>1)
                    {
                        button3.Visible = false;
                    }

                    if (textBox23.Text.Equals("0"))
                    {
                        button3.Enabled = false;
                    }
                    if (textBox23.Text.Equals("1"))
                    {
                        button3.Enabled = true;
                    }


                    if (textBox22.Text.Length>1)
                    {
                        button4.Visible = false;
                    }

                    if (textBox22.Text.Equals("0"))
                    {
                        button4.Enabled = false;
                    }
                    if (textBox22.Text.Equals("1"))
                    {
                        button4.Enabled = true;
                    }

                    if (textBox21.Text.Length>1)
                    {
                        button5.Visible = false;
                    }
                    if (textBox21.Text.Equals("0"))
                    {
                        button5.Enabled = false;
                    }
                    if (textBox21.Text.Equals("1"))
                    {
                        button5.Enabled = true;
                    }



                    if (textBox20.Text.Length>1)
                    {
                        button6.Visible = false;
                    }

                    if (textBox20.Text.Equals("0"))
                    {
                        button6.Enabled = false;
                    }

                    if (textBox20.Text.Equals("1"))
                    {
                        button6.Enabled = true;
                    }


                    if (textBox19.Text.Length>1)
                    {
                        button7.Visible = false;
                    }

                    if (textBox19.Text.Equals("0"))
                    {
                        button7.Enabled = false;
                    }
                    if (textBox19.Text.Equals("1"))
                    {
                        button7.Enabled = true;
                    }

                    if (textBox19.Text.Equals("0"))
                    {
                        button7.Enabled = false;
                    }
                    if (textBox19.Text.Equals("1"))
                    {
                        button7.Enabled = true;
                    }


                    if (textBox17.Text.Length>1)
                    {
                        button9.Visible = false;
                    }
                    if (textBox17.Text.Equals("0"))
                    {
                        button9.Enabled = false;
                    }
                    if (textBox17.Text.Equals("1"))
                    {
                        button9.Enabled = true;
                    }

                    if (textBox18.Text.Length>1)
                        button8.Visible = false;


                    if (textBox18.Text.Equals("0"))
                        button8.Enabled = false;
                    if (textBox18.Text.Equals("1"))
                        button8.Enabled = true;
             

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
          //  MessageBox.Show("1");
            textBox24.Text = time.ToString(format);
           // MessageBox.Show("1");
            MySqlConnection con = new MySqlConnection(myconnectionstring);
          //  MessageBox.Show("1");
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set pr='" + textBox24.Text + "', po='1' where fgd='" + fgd + "' ";
          //  MessageBox.Show("1");
            MySqlCommand cmd = new MySqlCommand();
          //  MessageBox.Show("1");
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

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox23.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set gav='" + textBox23.Text + "', grn1='1' where fgd='" + fgd + "' ";
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

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            textBox21.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set casee='" + textBox21.Text + "', grn2='1' where fgd='" + fgd + "' ";
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
            textBox20.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set po='" + textBox20.Text + "', mttv='1' where fgd='" + fgd + "' ";
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

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
          //  MessageBox.Show("1");
            string format = "g";   // Use this format.
           // MessageBox.Show("1");
            textBox18.Text = time.ToString(format);
          //  MessageBox.Show("1");
            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
          //  MessageBox.Show("1");
          //  String query = "update fgd set ttv='" + textBox18.Text + "', case='1' where fgd='" + fgd + "' ";

            String query = "update fgd set ttv='" + textBox18.Text + "', casee='1' where fgd='" + fgd + "' ";

          //  MessageBox.Show("1");
            MySqlCommand cmd = new MySqlCommand();
          //  MessageBox.Show("1");
            try
            {
                con.Open();
             //   MessageBox.Show("1");
                cmd.CommandText = query;
              //  MessageBox.Show("1");
                cmd.Connection = con;
             //   MessageBox.Show("1");
                cmd.ExecuteNonQuery();
            //    MessageBox.Show("1");
                con.Close();
              //  MessageBox.Show("1");
                reload();
                //MessageBox.Show("1");
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

        private void button2_Click(object sender, EventArgs e)
        {
            FGDStatus viewall = new FGDStatus();
            //  viewall.Closed += (s, args) => this.Close();
            viewall.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login p = new Login();
            p.Closed += (s, args) => this.Close();
            p.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Statusven status4 = new Statusven();
            //  viewall.Closed += (s, args) => this.Close();
            status4.Show();
        }
      
    }
}
