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
    public partial class Login : Form
    {
        string myconnectionstring = "Server=localhost;Database=users;user=root;password=rootPass ;";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int st = 0;
            String un = textBox1.Text;
            String pass = textBox2.Text;

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            MySqlCommand Cmd = con.CreateCommand();
            Cmd.CommandText = "select deptno from users  where username = '" + un + "' and password='" + pass + "' and allow='1'";


            try
            {
                con.Open();

                MySqlDataReader read = Cmd.ExecuteReader();
                while (read.Read())
                {
                   // MessageBox.Show("dept no =" + read[0].ToString());
                    st = Convert.ToInt32(read[0]);
                   // MessageBox.Show("dept no =" + st);
                }


                switch (st)
                {
                    case 1:
                        this.Hide();
                        planner p = new planner();
                        p.Closed += (s, args) => this.Close();
                        p.Show();
                        break;

                    case 2:
                        this.Hide();
                        vendor vn = new vendor();
                        vn.Closed += (s, args) => this.Close();
                        vn.Show();
                        break;

                    case 3:
                        this.Hide();
                        store sto = new store();
                        sto.Closed += (s, args) => this.Close();
                        sto.Show();
                        break;

                    case 4:
                        this.Hide();
                        production prod = new production();
                        prod.Closed += (s, args) => this.Close();
                        prod.Show();
                        break;

                    case 5:
                        this.Hide();
                        qc q = new qc();
                        q.Closed += (s, args) => this.Close();
                        q.Show();
                        break;

                    case 6:
                        this.Hide();
                        bg g = new bg();
                        g.Closed += (s, args) => this.Close();
                        g.Show();
                        break;

                    case 11:
                        this.Hide();
                        Data_entry de = new Data_entry();
                        de.Closed += (s, args) => this.Close();
                        de.Show();
                        break;


                    case 12:
                        this.Hide();
                        manager m = new manager();
                        m.Closed += (s, args) => this.Close();
                        m.Show();
                        break;

                    case 13:
                        this.Hide();
                        Admin a = new Admin();
                        a.Closed += (s, args) => this.Close();
                        a.Show();
                        break;


                    default :
                        MessageBox.Show("Please Enter valid Username Or Password...");
                        break;
                }


            }
            catch(Exception exc)
            {
                MessageBox.Show("Please Enter valid Username Or Password...");
            
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
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }


        
    

