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
    public partial class manager : Form
    {

        String fgd;
        string myconnectionstring = "Server=localhost;Database=fgd;user=root;password=rootPass;";

        public manager()
        {
            InitializeComponent();
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            label8.Text = null;
            label9.Text = null;
            label10.Text = null;
            label15.Text = null;
            label12.Text = null;
            label13.Text = null;
            label14.Text = null;
            label16.Text = null;
            label17.Text = null;
            label18.Text = null;
            label19.Text = null;
            label20.Text = null;
            label21.Text = null;
            label22.Text = null;
            

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

                DateTime co;
                 co=Convert.ToDateTime(cotb.Text);

                DateTime swp = Convert.ToDateTime(swptb.Text);
                label1.Text = Convert.ToString(swp - co);

                DateTime pr = Convert.ToDateTime(PRTB.Text);
                DateTime po = Convert.ToDateTime(POTB.Text);
                label2.Text = Convert.ToString(pr-swp);

                DateTime mttv = Convert.ToDateTime(MTTVTB.Text);
                DateTime gav = Convert.ToDateTime(GAVTB.Text);
               // label1.Text = Convert.ToString(swp - co);

                DateTime grn1 = Convert.ToDateTime(GRNTB.Text);
                DateTime mis = Convert.ToDateTime(MISTB.Text);
               // label1.Text = Convert.ToString(swp - co);

                DateTime mcp = Convert.ToDateTime(MCPTB.Text);
                DateTime mttp = Convert.ToDateTime(MTTPTB.Text);
                //label1.Text = Convert.ToString(swp - co);

                DateTime prod = Convert.ToDateTime(PTB.Text);
                DateTime marking = Convert.ToDateTime(MTB.Text);
      //          label1.Text = Convert.ToString(swp - co);

                DateTime pp = Convert.ToDateTime(PPTB.Text);
                DateTime qc = Convert.ToDateTime(QCTB.Text);
        //        label1.Text = Convert.ToString(swp - co);

                DateTime cpr = Convert.ToDateTime(CPRTB.Text);
                DateTime cpo = Convert.ToDateTime(CPOTB.Text);
          //      label1.Text = Convert.ToString(swp - co);

                DateTime ttv = Convert.ToDateTime(TTVTB.Text);
                DateTime casee = Convert.ToDateTime(CASETB.Text);
            //    label1.Text = Convert.ToString(swp - co);

                DateTime grn2 = Convert.ToDateTime(GRNFTB.Text);
                DateTime stock = Convert.ToDateTime(STB.Text);
              //  label1.Text = Convert.ToString(swp - co);

                DateTime invoice = Convert.ToDateTime(ITB.Text);
                //DateTime swp = Convert.ToDateTime(swptb.Text);
                //label1.Text = Convert.ToString(swp - co);

                //DateTime co = Convert.ToDateTime(cotb.Text);
                //DateTime swp = Convert.ToDateTime(swptb.Text);
                //label1.Text = Convert.ToString(swp - co);

                //DateTime co = Convert.ToDateTime(cotb.Text);
                //DateTime swp = Convert.ToDateTime(swptb.Text);
                //label1.Text = Convert.ToString(swp - co);

                //DateTime co = Convert.ToDateTime(cotb.Text);
                //DateTime swp = Convert.ToDateTime(swptb.Text);
                //label1.Text = Convert.ToString(swp - co);

                label3.Text = Convert.ToString(po-pr);
                label4.Text = Convert.ToString(mttv-po);
                label5.Text = Convert.ToString(gav - mttv);
                label6.Text = Convert.ToString(grn1-gav);
                label7.Text = Convert.ToString(mis-grn1);
                label8.Text = Convert.ToString(mcp-mis);
                label9.Text = Convert.ToString(mttp-mcp);
                label10.Text = Convert.ToString(prod-mttp);
                label12.Text = Convert.ToString(marking-prod);
                label13.Text = Convert.ToString(pp-marking);
                label17.Text = Convert.ToString(qc-pp);
                label16.Text = Convert.ToString(cpr-qc);
                label15.Text = Convert.ToString(cpo-cpr);
                label14.Text = Convert.ToString(ttv-cpo);
                label21.Text = Convert.ToString(casee-ttv);
                label20.Text = Convert.ToString(grn2-casee);
                label19.Text = Convert.ToString(stock-grn2);
                label18.Text = Convert.ToString(invoice-stock);
               label22.Text = Convert.ToString(invoice-co);









                /*
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
                */
            
            
            
            
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Error" + ex);


            }

        }

        private void pid_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                show.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
