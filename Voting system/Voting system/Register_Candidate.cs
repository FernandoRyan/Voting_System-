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
    public partial class Register_Candidate : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
        public Register_Candidate()
        {
            InitializeComponent();
        }
        private void Reg()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into candidatetb(NIC,name,DOB,candidateno,candidateadd,party,email)  values ('" + cdnic.Text + "','" + cdname.Text + "','" + cddob.Value.Date.ToString("yyyyMMdd") + "','" + cdno.Text + "','" + cdadd.Text + "', '" + cdparty.Text + "', '" + cdmail.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                cdnic.Text = "";
                cdname.Text = "";
                cddob.Value = DateTime.Now;
                cdno.Text = "";
                cdadd.Text = "";
                cdparty.Text = "";
                cdmail.Text = "";
                MessageBox.Show(" Voter Registerd Successfully ");
            }
            catch (SqlException er)
            {
                MessageBox.Show($"Internal Error:{er}");
            }


        }
        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Signoutbtn_Click(object sender, EventArgs e)
        {
            Admin A = new Admin();
            A.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            Reg();
        }
    }
}
