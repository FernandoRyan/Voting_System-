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
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Admin()
        {
            InitializeComponent();
        }

        private void uName_TextChanged(object sender, EventArgs e)
        {
           if(uName.Text.Equals(@"Username"))
            {
                uName.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (uName.Text.Equals(""))
            {
                uName.Text = @"Username";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if(PWD.Text.Equals("Password"))
            {
                PWD.Text = "";

            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (PWD.Text.Equals(""))
            {
                PWD.Text = "Password";

            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            con.Connection = con;
            con.CommandText = "select * from ";
            con.Close();
        }
    }
}
