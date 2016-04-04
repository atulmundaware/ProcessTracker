using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ptlogin
{
    public partial class planner : Form
    {
        String fgd;
        string myconnectionstring = "Server=localhost;Database=fgd;user=root;password=rootPass ;";
        public planner()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void planner_Load(object sender, EventArgs e)
        {
           // SqlCommand sqlCmd;
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login p = new Login();
            p.Closed += (s, args) => this.Close();
            p.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton17_Click(object sender, EventArgs e)
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
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            fgd = textBox1.Text;
            reload();

            //string sql = " UPDATE users  SET allow='0' where username='planner'";

            // MessageBox.Show("un="+un+"  pass="+pass);
            // MySqlCo sqlCnn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=flogin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
         
           }

        public void reload()
        {
            
            MySqlConnection con = new MySqlConnection(myconnectionstring);

          //  MySqlTransaction tr = null;
            MySqlCommand sqlCmd = con.CreateCommand();

            //sqlCmd.Transaction = tr;


            sqlCmd.CommandText = "select co,swp,pr,po,mis,mcp,mttp,production,marking,pp,cpr,cpo,stock,invoice from fgd where fgd='" + fgd + "'";



            try
            {
                con.Open();
              //  tr = con.BeginTransaction();

                MySqlDataReader read = sqlCmd.ExecuteReader();
                while (read.Read())
                {

                    textBox24.Text = read[0].ToString();
                    textBox20.Text = read[1].ToString();
                    textBox23.Text = read[2].ToString();
                    textBox10.Text = read[3].ToString();
                    textBox11.Text = read[4].ToString();
                    textBox19.Text = read[5].ToString();
                    textBox22.Text = read[6].ToString();
                    textBox12.Text = read[7].ToString();
                    textBox13.Text = read[8].ToString();
                    textBox18.Text = read[9].ToString();
                    textBox21.Text = read[10].ToString();
                    textBox14.Text = read[11].ToString();
                    textBox15.Text = read[12].ToString();
                    textBox17.Text = read[12].ToString();
                    textBox16.Text = read[13].ToString();


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

                    if (textBox20.Text.Length>1)
                    {
                        button7.Visible=false;
                    }

                    if (textBox20.Text.Equals("0"))
                    {
                        button7.Enabled = false;
                    }
                    if (textBox20.Text.Equals("1"))
                    {
                        button7.Enabled = true;
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


                    if (textBox19.Text.Length > 1)
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


                    if (textBox21.Text.Length>1)
                    {
                        button6.Visible = false;
                    }

                    if (textBox21.Text.Equals("0"))
                    {
                        button6.Enabled = false;
                    }
                    if (textBox21.Text.Equals("1"))
                    {
                        button6.Enabled = true;
                    }

                    if (textBox18.Text.Length > 1)
                        button9.Visible = false;

                    if (textBox18.Text.Equals("0"))
                        button9.Enabled = false;
                    if (textBox18.Text.Equals("1"))
                        button9.Enabled = true;


                    if (textBox17.Text.Length > 1)
                        button10.Visible = false;

                    if (textBox17.Text.Equals("0"))
                        button10.Enabled = false;
                    if (textBox17.Text.Equals("1"))
                        button10.Enabled = true;

                    if (textBox22.Text.Length>1)
                        button5.Visible = false;


                    if (textBox22.Text.Equals("0"))
                        button5.Enabled = false;

                    if (textBox22.Text.Equals("1"))
                        button5.Enabled = true;
                }

                //tr.Commit();
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
            MySqlTransaction tr = null;

            //MySqlCommand sqlCmd = con.CreateCommand();
            String query= "update fgd set co='"+textBox24.Text+"', swp='1' where fgd='"+fgd+"' ";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Transaction = tr;
                    
            try
            {
                con.Open();                              
                cmd.CommandText = query;

                cmd.Connection = con;
                tr = con.BeginTransaction();
                cmd.ExecuteNonQuery();
                tr.Commit();
                reload();
                con.Close();
                //reload();
              

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
            MySqlTransaction tr = null;


            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set pp='" + textBox24.Text + "', qc='1' where fgd='" + fgd + "' ";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Transaction = tr;

            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                tr = con.BeginTransaction();
                cmd.ExecuteNonQuery();
                tr.Commit();
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

            string c = textBox19.Text;

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set mcp='" + textBox19.Text + "', mttp='1',pr='" + c + "',po='" + c + "',mttv='" + c + "',gav='" + c + "',grn1='" + c + "',mis='" + c + "' where fgd='" + fgd + "' and mis='0'";
            String query1 = "update fgd set mcp='" + textBox19.Text + "', mttp='1' where fgd='" + fgd + "'";
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                string op = cmd.ExecuteNonQuery().ToString();
               // MessageBox.Show(op);
                if(op.Equals("0"))
                {
                    cmd.CommandText = query1;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                }
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
            String query = "update fgd set pr='" + textBox23.Text + "', po='1',mcp='0' where fgd='" + fgd + "' ";
            button8.Enabled = false;

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
            String query = "update fgd set mttp='" + textBox24.Text + "', production='1' where fgd='" + fgd + "' ";
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
            String query = "update fgd set cpr='" + textBox21.Text + "', cpo='1' where fgd='" + fgd + "' ";
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
            String query = "update fgd set swp='" + textBox20.Text + "', pr='1',mcp='1' where fgd='" + fgd + "' ";
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                reload();
                con.Close();
               // reload();
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
                reload();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }

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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.Hide();
            FGDStatus viewall = new FGDStatus();
          //  viewall.Closed += (s, args) => this.Close();
            viewall.Show();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Status status = new Status();
            //  viewall.Closed += (s, args) => this.Close();
            status.Show();

        }

       
        }
        
    }

