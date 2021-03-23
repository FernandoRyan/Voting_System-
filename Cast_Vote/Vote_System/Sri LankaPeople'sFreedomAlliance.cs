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
    public partial class Sri_LankaPeople_sFreedomAlliance : Form
    {
        Connection connection = new Connection();




        public Sri_LankaPeople_sFreedomAlliance()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        public void loadCandidates()
        {
            String qry = "SELECT * FROM CANIDATES WHERE PARLIMENT_=";





        }


    }
}
