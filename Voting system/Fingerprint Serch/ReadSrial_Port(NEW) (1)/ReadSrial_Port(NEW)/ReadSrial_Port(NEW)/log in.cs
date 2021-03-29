using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ReadSrial_Port_NEW_
{
    public partial class log_in : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\GitHub\Voting_System-\DB\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
        public log_in()
        {
            InitializeComponent();
        }
        private void login()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Logintb WHERE userName='" + uName.Text + "' AND PWD='" + PWD.Text + "'", con);

                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    if (uName.Text == "Nethma" && PWD.Text == "Nethma12345")
                    {
                        QR_Reader qr = new QR_Reader();
                        qr.Show();
                        this.Hide();

                    }

                }
                else
                    MessageBox.Show("Invalid username or password");
            }

            catch (SqlException es)
            {
                MessageBox.Show($"Internal Error:{es}");
            }
        }
            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
