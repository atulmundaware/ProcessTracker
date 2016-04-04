using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptlogin
{
    public partial class FGDStatus : Form
    {
        String fgd;
        string myconnectionstring = "Server=192.168.198.193;Database=fgd;user=root;password= rootPass;";
        
        public FGDStatus()
        {
            InitializeComponent();
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
                   MTTPTB .Text = read[11].ToString();
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


        private void pid_TextChanged(object sender, EventArgs e)
        {

        }

        private void FGDStatus_Load(object sender, EventArgs e)
        {

        }

        private void ITB_TextChanged(object sender, EventArgs e)
        {

        }

        private void I_Click(object sender, EventArgs e)
        {

        }

        private void STB_TextChanged(object sender, EventArgs e)
        {

        }

        private void GRNFTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void S_Click(object sender, EventArgs e)
        {

        }

        private void GRNF_Click(object sender, EventArgs e)
        {

        }

        private void CASETB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CASE_Click(object sender, EventArgs e)
        {

        }

        private void TTVTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTV_Click(object sender, EventArgs e)
        {

        }

        private void CPOTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void COPO_Click(object sender, EventArgs e)
        {

        }

        private void CPR_Click(object sender, EventArgs e)
        {

        }

        private void QCTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PPTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void QC_Click(object sender, EventArgs e)
        {

        }

        private void PP_Click(object sender, EventArgs e)
        {

        }

        private void MTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void P_Click(object sender, EventArgs e)
        {

        }

        private void MTTPTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void MCPTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void MTTP_Click(object sender, EventArgs e)
        {

        }

        private void MCP_Click(object sender, EventArgs e)
        {

        }

        private void MISTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void GRNTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void MIS_Click(object sender, EventArgs e)
        {

        }

        private void GRN_Click(object sender, EventArgs e)
        {

        }

        private void GAVTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void MTTVTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void GAV_Click(object sender, EventArgs e)
        {

        }

        private void MTTV_Click(object sender, EventArgs e)
        {

        }

        private void POTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PO_Click(object sender, EventArgs e)
        {

        }

        private void PR_Click(object sender, EventArgs e)
        {

        }

        private void swptb_TextChanged(object sender, EventArgs e)
        {

        }

        private void cotb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DONE_Click(object sender, EventArgs e)
        {

        }

        private void swp_Click(object sender, EventArgs e)
        {

        }

        private void co_Click(object sender, EventArgs e)
        {

        }

        private void Product_Click(object sender, EventArgs e)
        {

        }
    }
}
