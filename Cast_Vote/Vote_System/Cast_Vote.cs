using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vote_System
{
    public partial class Cast_Vote : Form
    {
        public Cast_Vote()
        {
            InitializeComponent();
        }

        private void SPFA_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SPFA_radioBtn.Checked)
            {

                Sri_LankaPeople_sFreedomAlliance SPFA = new Sri_LankaPeople_sFreedomAlliance();
                SPFA.Show();
                this.Hide();

            }
        }

        private void SJB_Radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SJB_Radiobtn.Checked)
            {

                Samagi_Jana_Balawegaya SJB = new Samagi_Jana_Balawegaya();
                SJB.Show();
                this.Hide();

            }
        }

        private void TNPF_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (TNPF_radioBtn.Checked)
            {

                Tamil_National_People_s_Front TNPF = new Tamil_National_People_s_Front();
                TNPF.Show();
                this.Hide();
            }
        }

        private void TNA_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (TNA_radioBtn.Checked)
            {

                Tamil_National_Alliance TNA = new Tamil_National_Alliance();
                TNA.Show();
                this.Hide();

            }
        }
    }
}
