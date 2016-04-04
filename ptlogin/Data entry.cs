using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel; 

namespace ptlogin
{
    public partial class Data_entry : Form
    {

        string connectionstring = "Server=localhost;Database=fgd;user=root;password=rootPass";


        public Data_entry()
        {
            InitializeComponent();
        
        
        
        }

       

        private void Data_entry_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("FG");
            //comboBox1.Items.Add("FGD");
        }

        private void button1_Click(object sender, EventArgs e)
        {



            String s = richTextBox1.Text;
            MessageBox.Show(s);
            string[] words = s.Split('\t');
            string fg=null, fgd=null;
            /*    string[] wa = s.Split('\t');
                foreach (string w in wa)
                {

                    MessageBox.Show(w);

                }*/

             //   MessageBox.Show(word);
            
           

            


            //string s = "there is a cat";
           // String
          //  String ss = richTextBox1.Text;
            // Split string on spaces.
            // ... This will separate all the words.
         



            MySqlConnection connection = new MySqlConnection(connectionstring);

            try
            {
                MySqlCommand command = connection.CreateCommand();

              //  command.CommandText = "INSERT INTO fgd (fgd) VALUES ('tom'),('dfgs'),('sergf')";
               
                connection.Open();
                int ct = 1;
                 foreach (string word in words)
            {

                if (ct % 2 != 0)
                {
                    fg = word;
                }
                if (ct % 2 == 0)
                {
                    fgd = word;
                    if (word.Length > 3)
                    {
                        command.CommandText = "INSERT INTO fgd (fg,fgd) values ('" + fg + "','" + fgd + "')";
                        command.ExecuteNonQuery();
                    }
                }
                ct++;
            }


               
                //return "Mitarbeiter wurde angelegt";
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
