using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_system
{
    public partial class CandidateResultsInfo : Form
    {
        //Declarations of public member variables
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryana\OneDrive\Documents\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
        string candidateno;
        int noOfVoted = 0;
        string noOfVoterRegistered;
        public CandidateResultsInfo()
        {
            InitializeComponent();
            electionWinner();
            countrows();
            registeredVoters();
        }

        /*Method for getting winner details*/
        private void electionWinner()
        {

            winnerDetails();

        }


        //Get winner details

        private void winnerDetails() {

            try
            {
                conn.Open();
                string qry = "SELECT * FROM Results WHERE Results=(SELECT MAX(Results) FROM Results) ";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {

                    candidateno = DR1.GetValue(0).ToString();
                    //  string candidateparty = DR1.GetValue(1).ToString();
                    //string candidateresults = DR1.GetValue(2).ToString();
                    //winnerlbl.Text = "Candidateno:" + "" + "" + "" + candidateno;


                }
            }
            catch (SqlException es)
            {

                MessageBox.Show($"{es}");
            }
            finally {
                conn.Close();
                getName();
            }
        }


        private void getName()
        {

            try
            {
                conn.Open();
                string qry = "SELECT full_name FROM candidate_tb WHERE CandidateNumber=@candidateno";
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("candidateno", candidateno);
                SqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {

                    winnerlbl.Text = DR1.GetValue(0).ToString();


                }
            }
            catch (SqlException es)
            {

                MessageBox.Show($"{es}");
            }
            finally {

                conn.Close();

            }


        }

        /* Counting the of people who voted */

        public void countrows()
        {
            string stmt = "SELECT SUM(Results) FROM Results";
          

            using (SqlConnection thisConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryana\OneDrive\Documents\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    noOfVoted = (int)cmdCount.ExecuteScalar();

                }
            }

            voterslbl.Text = noOfVoted.ToString();
        }

        private void registeredVoters() {

            try
            {
                conn.Open();
                string qry = "SELECT MAX(number) FROM VoterTb";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {
                    noOfVoterRegistered = DR1.GetValue(0).ToString();
                    registeredVoterLbl.Text = DR1.GetValue(0).ToString();


                }
            }
            catch (SqlException es)
            {

                MessageBox.Show($"{es}");
            }
            finally
            {

                conn.Close();

            }


        }

        private void Notvotered() {
            int i = int.Parse(noOfVoterRegistered);
            int count = i - noOfVoted;
            UnvotedLbls.Text = count.ToString();


        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            Election_Results results = new Election_Results();
            this.Hide();
            results.Show();
        }

        private void Signoutbtn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
