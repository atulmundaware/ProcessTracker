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
    public partial class Statusven : Form
    {
      //  List<TextBox> name = new List<TextBox>();
        List<Label> la = new List<Label>();
        List<Label> la2 = new List<Label>();
        //   List<Button> b = new List<Button>();
        String fgd, co;
        int length, sum = 0;
        string eq = "1";



        public Statusven()
        {
            InitializeComponent();
        }

        private void Statusven_Load(object sender, EventArgs e)
        {

            string myconnectionstring = "Server=192.168.198.193;Database=fgd;user=root;password=rootPass ;";

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            MySqlCommand sqlCmd = con.CreateCommand();
            // sqlCmd.CommandText = "select fgd,co,pr,mttv,cpr,swp,mcp,pp,stock from fgd where co='1' or pr='1' or mttv='1' or cpr='1' or swp='1' or mcp='1' or pp='1' or stock='1'";
            sqlCmd.CommandText = "SELECT fgd,pr,po,gav,cpr,cpo,ttv,casee,stock FROM fgd where pr='1' or po='1' or gav='1' or cpr='1' or cpo='1' or ttv='1' or casee='1' or stock='1' ";
            // MySqlDataReader read = sqlCmd.ExecuteReader();
            try
            {
                con.Open();


                MySqlDataReader read = sqlCmd.ExecuteReader();
                string g;
                int f, i = 0;


                while (read.Read())
                {



                    la.Add(new Label()
                    {
                        Location = new System.Drawing.Point(50, 50 + i * 25),
                        Size = new System.Drawing.Size(75, 20)

                    });
                    this.Controls.Add(la[i]);
                    la[i].Text = read[0].ToString();





                    la2.Add(new Label()
                    {
                        Location = new System.Drawing.Point(150, 50 + i * 25),
                        Size = new System.Drawing.Size(75, 20)

                    });
                    this.Controls.Add(la2[i]);

                    // string eq = "1";

                    if (read[1].Equals(eq))
                    {


                        la2[i].Text = "PR";

                    }

                    if (read[2].Equals(eq))
                    {
                        la2[i].Text = "PO";

                    }

                    if (read[3].Equals(eq))
                    {
                        la2[i].Text = "GAV";

                    }

                    if (read[4].Equals(eq))
                    {
                        la2[i].Text = "CPR";

                    }



                    if (read[5].Equals(eq))
                    {
                        la2[i].Text = "CPO";

                    }

                    if (read[6].Equals(eq))
                    {
                        la2[i].Text = "TTV";

                    }

                    if (read[7].Equals(eq))
                    {
                        la2[i].Text = "CASE";

                    }

                    if (read[8].Equals(eq))
                    {
                        la2[i].Text = "STOCK";

                    }





                    /*
                    name.Add(new TextBox()
                    {
                        Location = new System.Drawing.Point(200, 50 + i * 25),
                        Size = new System.Drawing.Size(156, 20)
                    });
                    this.Controls.Add(name[i]);*/

              /*      b.Add(new Button()
                    {
                        Location = new System.Drawing.Point(350, 50 + i * 25),
                        Size = new System.Drawing.Size(75, 20)






                    });

                    this.Controls.Add(b[i]);
                    b[i].Text = "DONE";*/

                 //   b[i].Click += new EventHandler(this.dclick);


                    /*   name.Add(new TextBox()
                       {
                           Location = new System.Drawing.Point(137, 158 + i * 25),
                           Size = new System.Drawing.Size(156, 20)
                       });
                       this.Controls.Add(name[i]);
                       */
                    /*
                                        b[i].Click += delegate
                                        {


                                            planner p = new planner();
                                            p.Closed += (s, args) => this.Close();
                                            p.Show();
                        


                                           // MessageBox.Show("rdtrfg");
                        


                        

                                            DateTime time = DateTime.Now;             // Use current time.
                                            string format = "g";   // Use this format.
                                            name[i].Text = time.ToString(format);


                                            //    MySqlConnection con = new MySqlConnection(myconnectionstring);
                                            //MySqlCommand sqlCmd = con.CreateCommand();

                                            // String query = "update fgd set stock='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";
                                            if (read[1].Equals(eq))
                                            {


                                                sqlCmd.CommandText = "update fgd set co='" + name[0].Text + "', swp='1' where fgd='" + fgd + "' ";

                                            }

                                            if (read[2].Equals(eq))
                                            {
                                                sqlCmd.CommandText = "update fgd set pr='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";

                                            }

                                            if (read[3].Equals(eq))
                                            {
                                                sqlCmd.CommandText = "update fgd set mttv='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";

                                            }

                                            if (read[4].Equals(eq))
                                            {
                                                sqlCmd.CommandText = "update fgd set cpr='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";

                                            }



                                            if (read[5].Equals(eq))
                                            {
                                                sqlCmd.CommandText = "update fgd set swp='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";

                                            }

                                            if (read[6].Equals(eq))
                                            {
                                                sqlCmd.CommandText = "update fgd set mcp='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";

                                            }

                                            if (read[7].Equals(eq))
                                            {
                                                sqlCmd.CommandText = "update fgd set pp='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";

                                            }

                                            if (read[8].Equals(eq))
                                            {
                                                sqlCmd.CommandText = "update fgd set stock='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";

                                            }







                                            //  MySqlCommand cmd = new MySqlCommand();





                                            //  MessageBox.Show("hello");
                        
                                        };

                                        */


                    i++;




                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }


        }

        
/*
        private void dclick(object sender, EventArgs e)
        {
           // throw new NotImplementedException();


            string g;
            String query;
            int f, i = 0;
            i = i + sum;

            sum = sum + 1;
            //  while (read.Read())
            // {
            //  MessageBox.Show(sum.ToString());

            DateTime time = DateTime.Now;             // Use current time.
            string format = "g";   // Use this format.
            name[i].Text = time.ToString(format);
            string myconnectionstring = "Server=192.168.198.193;Database=fgd;user=root;password=rootPass ;";

            MySqlConnection con = new MySqlConnection(myconnectionstring);
            MySqlCommand sqlCmd = con.CreateCommand();
            sqlCmd.CommandText = "SELECT fgd,co,pr,mttv,cpr,swp,mcp,pp,stock FROM fgd where  co='1' or pr='1' or mttv='1' or cpr='1' or swp='1' or mcp='1' or pp='1' or stock='1' ";
       //     MySqlDataReader read = sqlCmd.ExecuteReader();
            
            try
            {

                con.Open();

                MySqlDataReader read = sqlCmd.ExecuteReader();

                //con.Open();

                while (read.Read())
                {

                    if (read[1].Equals(eq))
                    {


                         sqlCmd.CommandText = "update fgd set co='" + name[i].Text + "', swp='1' where fgd='" + fgd + "' ";
                       // query = "update fgd set co='" + name[i].Text + "' where fgd='" + fgd + "' ";
                       // sqlCmd.CommandText = query;
                         // sqlCmd.Connection = con;
                        // sqlCmd.ExecuteNonQuery();
                        //MySqlCommand cmd = new MySqlCommand();
                    }

                    if (read[2].Equals(eq))
                    {



                         sqlCmd.CommandText = "update fgd set pr='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";
                        //query = "update fgd set pr='" + name[i].Text + "' where fgd='" + fgd + "' ";
                        //MySqlCommand cmd = new MySqlCommand();
                        //sqlCmd.CommandText = query;
                        // sqlCmd.Connection = con;
                      //  sqlCmd.ExecuteNonQuery();
                    }

                    if (read[3].Equals(eq))
                    {



                         sqlCmd.CommandText = "update fgd set mttv='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";
                       // query = "update fgd set mttv='" + name[i].Text + "' where fgd='" + fgd + "' ";
                        //MySqlCommand cmd = new MySqlCommand();
                       // sqlCmd.CommandText = query;
                         // sqlCmd.Connection = con;
                     //   sqlCmd.ExecuteNonQuery();
                    }

                    if (read[4].Equals(eq))
                    {



                        sqlCmd.CommandText = "update fgd set cpr='" + name[3].Text + "', invoice='1' where fgd='" + fgd + "' ";
                       // query = "update fgd set cpr='" + name[i].Text + "' where fgd='" + fgd + "' ";
                        //MySqlCommand cmd = new MySqlCommand();
                      //  sqlCmd.CommandText = query;
                        //  sqlCmd.Connection = con;
                      //  sqlCmd.ExecuteNonQuery();
                    }



                    if (read[5].Equals(eq))
                    {


                        sqlCmd.CommandText = "update fgd set swp='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";
                       // query = "update fgd set swp='" + name[i].Text + "' where fgd='" + fgd + "' ";
                        //    MySqlCommand cmd = new MySqlCommand();
                       // sqlCmd.CommandText = query;
                        // sqlCmd.Connection = con;
                        //sqlCmd.ExecuteNonQuery();
                    }

                    if (read[6].Equals(eq))
                    {


                        sqlCmd.CommandText = "update fgd set mcp='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";
                       // query = "update fgd set mcp='" + name[i].Text + "' where fgd='" + fgd + "' ";
                        //  MySqlCommand cmd = new MySqlCommand();
                       // sqlCmd.CommandText = query;
                         //sqlCmd.Connection = con;
                    //    sqlCmd.ExecuteNonQuery();
                    }

                    if (read[7].Equals(eq))
                    {



                        sqlCmd.CommandText = "update fgd set pp='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";
                        //query = "update fgd set pp='" + name[i].Text + "' where fgd='" + fgd + "' ";
                        //sqlCmd.CommandText = query;

                         //sqlCmd.Connection = con;
                      //  sqlCmd.ExecuteNonQuery();
                        //MySqlCommand cmd = new MySqlCommand();
                    }

                    if (read[8].Equals(eq))
                    {



                        sqlCmd.CommandText = "update fgd set stock='" + name[i].Text + "', invoice='1' where fgd='" + fgd + "' ";
                        //query = "update fgd set stock='" + name[i].Text + "' where fgd='" + fgd + "' ";
                        //sqlCmd.CommandText = query;
                          //sqlCmd.Connection = con;
                     //   sqlCmd.ExecuteNonQuery();
                        //                    MySqlCommand cmd = new MySqlCommand();
                    }
                    //  query = "update fgd set pr='" + name[i].Text + "', po='1' where fgd='" + fgd + "' ";
                    //   i++;

                    //  query = "update fgd set pr='" + name[i].Text + "', po='1' where fgd='" + fgd + "' ";
                    // }
                    //  sqlCmd.CommandText = query;
                    // sqlCmd.Connection = con;
                    //sqlCmd.ExecuteNonQuery();
                    //sum++;
                }
                    con.Close();
                }
                
            
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }

        }
 * */
            }

        }
        


        
