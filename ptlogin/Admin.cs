using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ptlogin
{
    public partial class Admin : Form
    {
        String fgd;
        string myconnectionstring = "Server=192.168.198.193;Database=fgd;user=root;password=rootPass ;";

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            cotb.Text = time.ToString(format);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            swptb.Text = time.ToString(format);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            PRTB.Text = time.ToString(format);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            POTB.Text = time.ToString(format);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            MTTVTB.Text = time.ToString(format);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            GAVTB.Text = time.ToString(format);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            GRNTB.Text = time.ToString(format);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            MISTB.Text = time.ToString(format);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            MCPTB.Text = time.ToString(format);





        }

        private void button14_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            MTTPTB.Text = time.ToString(format);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            PTB.Text = time.ToString(format);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            MTB.Text = time.ToString(format);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            PPTB.Text = time.ToString(format);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            QCTB.Text = time.ToString(format);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            CPRTB.Text = time.ToString(format);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            CPOTB.Text = time.ToString(format);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            TTVTB.Text = time.ToString(format);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            CASETB.Text = time.ToString(format);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            GRNFTB.Text = time.ToString(format);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            STB.Text = time.ToString(format);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            ITB.Text = time.ToString(format);
        }

        private void show_Click(object sender, EventArgs e)
        {
            fgd = pid.Text;
            reload();
        }

        public void reload()
        {

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            MySqlCommand sqlCmd = con.CreateCommand();
            sqlCmd.CommandText = "select * from fgd where fgd='" + fgd + "'";

            try
            {
                con.Open();

                MySqlDataReader read = sqlCmd.ExecuteReader();
                while (read.Read())
                {

                    cotb.Text = read[2].ToString();
                    swptb.Text = read[3].ToString();
                    PRTB.Text = read[4].ToString();
                    POTB.Text = read[5].ToString();
                    MTTVTB.Text = read[6].ToString();
                    GAVTB.Text = read[7].ToString();
                    GRNTB.Text = read[8].ToString();
                    MISTB.Text = read[9].ToString();
                    MCPTB.Text = read[10].ToString();
                    MTTPTB.Text = read[11].ToString();
                    // MTB.Text = read[12].ToString();
                    PTB.Text = read[12].ToString();
                    MTB.Text = read[13].ToString();
                    PPTB.Text = read[14].ToString();
                    QCTB.Text = read[15].ToString();
                    CPRTB.Text = read[16].ToString();
                    CPOTB.Text = read[17].ToString();
                    TTVTB.Text = read[18].ToString();
                    CASETB.Text = read[19].ToString();
                    GRNFTB.Text = read[20].ToString();
                    STB.Text = read[21].ToString();
                    ITB.Text = read[22].ToString();



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
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            cotb.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            // Use current time.
            String query = "update fgd set co='" + cotb.Text + "' where fgd='" + fgd + "' ";
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

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            swptb.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set swp='" + swptb.Text + "' where fgd='" + fgd + "'";
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

        private void button25_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            PRTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            // Use current time.
            String query = "update fgd set pr='" + PRTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button22_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            POTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set po='" + POTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button29_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            MTTVTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set mttv='" + MTTVTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button28_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            GAVTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set gav='" + GAVTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button27_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            GRNTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set grn1='" + GRNTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button26_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            MISTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set mis='" + MISTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button33_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            MCPTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set mcp='" + MCPTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button32_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            MTTVTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set mttp='" + MTTVTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button30_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            MTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set marking='" + MTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button37_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            PPTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set pp='" + PPTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button36_Click(object sender, EventArgs e)
        {



            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            QCTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set qc='" + QCTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button35_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            CPRTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set cpr='" + CPRTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button34_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            CPOTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set cpo='" + CPOTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button41_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            TTVTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set ttv='" + TTVTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button40_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            CASETB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set case='" + CASETB.Text + "' where fgd='" + fgd + "' ";
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

        private void button39_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            GRNFTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set grn2='" + GRNFTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button38_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            STB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set stock='" + STB.Text + "' where fgd='" + fgd + "' ";
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

        private void button42_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            ITB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set invoice='" + ITB.Text + "' where fgd='" + fgd + "' ";
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

        private void button31_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            PTB.Text = time.ToString(format);

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            //MySqlCommand sqlCmd = con.CreateCommand();
            String query = "update fgd set production='" + PTB.Text + "' where fgd='" + fgd + "' ";
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

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        /*MySqlConnection con = new MySqlConnection(myconnectionstring);
        //MySqlCommand sqlCmd = con.CreateCommand();
        String query = "update fgd set co='" + textBox24.Text + "', swp='1' where fgd='" + fgd + "' ";
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
         */

    }
}



