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

namespace Vote_System
{
    public partial class Tamil_National_Alliance : Form
    {
        //Declaration of public variables 

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryana\OneDrive\Documents\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
        string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryana\OneDrive\Documents\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
        int count = 0;


        public Tamil_National_Alliance()
        {
            InitializeComponent();
            loadCandidates();
        }



        /*
         The method for getting all candidates of samagi jana balawegaya
        party into a grid view for voting purposes
         */
        private void loadCandidates()
        {

            String qry = "SELECT CandidateNumber FROM candidate_tb WHERE party ='Tamil National Alliance'";
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

        private void Tamil_National_Alliance_Load(object sender, EventArgs e)
        {

            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkboxcolumn";
            chkbox.ReadOnly = false;
            dataGridView1.Columns.Insert(0, chkbox);
            DataGridViewColumn column = dataGridView1.Columns[1];
            column.Width = 450;
            DataGridViewColumn column1 = dataGridView1.Columns[0];
            column1.Width = 50;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            countVotes();//method for counting how many checkbox were checked 

            if (count < 1)
            {
                MessageBox.Show("Please select a candidate to vote");
                return;
            }
            else
            {

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {

                    bool checkedbox = Convert.ToBoolean(dr.Cells["checkboxcolumn"].Value);
                    if (checkedbox == true && count < 3)
                    {
                        insertRecords();//Calling method for insertion data to database
                    }
                }

            }
        }

        private void countVotes()
        {

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                bool checkedbox = Convert.ToBoolean(dr.Cells["checkboxcolumn"].Value);

                if (checkedbox)
                {

                    count++;

                    if (count > 3)
                    {

                        MessageBox.Show($"Number of allowed voting exceeded only 3 voting allowed :{count}");
                        return;
                    }

                }
            }

        }

        private void insertRecords()
        {


            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {



                using (var conn1 = new SqlConnection(connectionstring))
                    try
                    {
                        conn1.Open();

                        string query = "SELECT COUNT(*) FROM Results WHERE CandidateNumber=@no";
                        SqlCommand cmd = new SqlCommand(query, conn1);

                        cmd.Parameters.AddWithValue("@no", dr.Cells[1].Value);


                        using (cmd)
                        {
                            int rowsAmount = (int)cmd.ExecuteScalar(); // get the value of the count
                            if (rowsAmount > 0)
                            {
                                string Update = "update Results set Results=Results+1";
                                SqlCommand cmd1 = new SqlCommand(Update, conn1);
                                cmd1.ExecuteNonQuery();
                            }
                            else
                            {

                                string qry = "INSERT INTO Results (CandidateNumber,party,Results) VALUES(@CandidateNumber,@party,@Results)";
                                try
                                {

                                    SqlCommand cmd2 = new SqlCommand(qry, conn1);

                                    cmd2.Parameters.AddWithValue("@CandidateNumber", dr.Cells[1].Value);
                                    cmd2.Parameters.AddWithValue("@party", "Tamil National Alliance");
                                    cmd2.Parameters.AddWithValue("@Results", 1);
                                    cmd2.ExecuteNonQuery();
                                    conn1.Close();
                                    MessageBox.Show("Voted sucessfully");


                                }
                                catch (SqlException es)
                                {

                                    MessageBox.Show($"{es}");
                                }
                                finally
                                {
                                    Vote cs = new Vote();
                                    cs.Show();
                                    this.Close();

                                }
                            }

                        }


                    }

                    catch (SqlException es)
                    {
                        MessageBox.Show($"Error: {es}");
                    }
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Cast_Vote cv = new Cast_Vote();
            this.Close();
            cv.Show();
   
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.FromArgb(15, 48, 87);
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.FromArgb(3, 80, 111);
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FromArgb(15, 48, 87);
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FromArgb(3, 80, 111);
        }
    }
}
