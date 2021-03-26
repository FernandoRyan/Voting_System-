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

        public Admin()
        {
            InitializeComponent();
        }


        private void login()
        {
            try {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Logintb WHERE userName='" + uName.Text + "' AND PWD='" + PWD.Text + "'", con);

                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    if (uName.Text == "AKBO" && PWD.Text == "Akbo12345")
                    {
                        Election_Results er = new Election_Results();
                        er.Show();
                        this.Hide();

                    }
                    else if (uName.Text == "AKILA" && PWD.Text == "Akila12345")
                    {
                        Register_Candidate RC = new Register_Candidate();
                        RC.Show();
                        this.Hide();
                    }
                    else if (uName.Text == "Nethma" && PWD.Text == "Nethma12345")
                    {
                        Register_Voter RV = new Register_Voter();
                        RV.Show();
                        this.Hide();

                    }

                }
                else
                    MessageBox.Show("Invalid username or password");
            }
            
            catch (SqlException es) {
                MessageBox.Show($"Internal Error:{es}");
            }

            }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
