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
    public partial class Register_Voter : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\GitHub\Voting_System-\DB\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
        public Register_Voter()
        {
            InitializeComponent();
        }
        private void reg()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into VoterTb(NIC,name,DOB,fingerprintID,telephone,GND)  values ('" + nictxt.Text + "','" + VTRname.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "','" + idtxt.Text + "','" + tptxt.Text + "', '" + gntxt.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                
                MessageBox.Show(" Voter Registerd Successfully ");
            }
            catch(SqlException er)
            {
                MessageBox.Show($"Internal Error:{er}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reg();
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addf ad = new addf();
            ad.Show();
            this.Hide();
        }
    }

    internal class Sqlconnection
    {
    }
}
