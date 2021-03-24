using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Voting_system
{
    public partial class Admin : Form
    {
        //Establishing the database connectivity
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryana\OneDrive\Documents\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        public Admin()
        {
            InitializeComponent();
        }

     

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con != null)
                {
                    MessageBox.Show("Conn is sucess");
                }
                else {
                    MessageBox.Show("Conn failed");
                }
            }
            catch (Exception ef)
            {

                MessageBox.Show($"Error{ef}");
            }
              
        }
    }
}
