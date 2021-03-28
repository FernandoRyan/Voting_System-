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
    public partial class Election_Results : Form
    {
        /* Declaration of public variables */
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryana\OneDrive\Documents\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
       

        public Election_Results()
        {
            InitializeComponent();
            dateCheck();
            loadResults();
        }

        private void dateCheck()
        {
            label1.Text= DateTime.Now.ToString();
        }

        /* The method for election results**/
        private void loadResults()
        {
            String qry = "SELECT CandidateNumber,party,Results FROM Results ";
            try
            {
                conn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(qry, conn);
                SqlCommandBuilder objSqlCommandBuilder = new SqlCommandBuilder(SDA);
                DataTable objDataTable = new DataTable();
                SDA.Fill(objDataTable);
                BindingSource objBindingSource = new BindingSource();
                objBindingSource.DataSource = objDataTable;
                dataGridView1.DataSource = objBindingSource;

                SDA.Update(objDataTable);
                conn.Close();


            }
            catch (Exception es)
            {

                MessageBox.Show($"Internal error: {es}");
            }
        }

        /* Formating datagrid view*/

        private void Election_Results_Load(object sender, EventArgs e)
        {

            DataGridViewColumn column3 = dataGridView1.Columns[2];
            column3.Width = 150;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 450;
            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 100;
        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void DetailedReportbtn_Click(object sender, EventArgs e)
        {
            CandidateResultsInfo rc = new CandidateResultsInfo();
            this.Hide();
            rc.Show();
        }

        private void Signoutbtn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }
    }
}
