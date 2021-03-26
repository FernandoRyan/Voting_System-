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
using System.Configuration;

namespace Vote_System
{
    public partial class Samagi_Jana_Balawegaya : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryana\OneDrive\Documents\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
        CheckedListBox checklist = new CheckedListBox();
        public Samagi_Jana_Balawegaya()
        {
            InitializeComponent();

            loadCandidates();
        }




        /*
         The method for getting all candidates of samagi jana balawegaya party
         */
        private void loadCandidates()
        {

            //   int count = countCandidates();

            String qry = "SELECT full_name , candidate_no FROM candidate_tb WHERE party ='Samagi Jana Balawegaya'";
            try
            {
                conn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(qry,conn);
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

       
        private void Samagi_Jana_Balawegaya_Load(object sender, EventArgs e)
        {
          
            
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkboxcolumn";
            chkbox.ReadOnly = false;
            dataGridView1.Columns.Insert(0,chkbox);
            DataGridViewColumn column = dataGridView1.Columns[1];
            column.Width = 200;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           int count = 0;


            foreach (DataGridViewRow dr in dataGridView1.Rows) {

                bool checkedbox = Convert.ToBoolean(dr.Cells["checkboxcolumn"].Value);

                if (checkedbox)
                {

                    count++;

                    if (count >= 3)
                    {

                        MessageBox.Show($"Number of allowed voting exceeded only 3 voting allowed :{count}");
                        return;
                    }
                }
            }

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                bool checkedbox = Convert.ToBoolean(dr.Cells["checkboxcolumn"].Value);
                if (checkedbox==true && count<3)
                {
              

                    string qry = "INSERT INTO Results (candidate_name,party,Results) VALUES(@candidate_name,@party,@Results)";
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(qry, conn);

                        cmd.Parameters.AddWithValue("@candidate_name", dr.Cells[1].Value);
                        cmd.Parameters.AddWithValue("@party", "Samagi Jana Balawegaya");
                        cmd.Parameters.AddWithValue("@Results", 1);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Voted sucessfully");
                    }
                    catch (SqlException es)
                    {

                        MessageBox.Show($"{es}");
                    }
                }
                    
                }


            }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Cast_Vote cv = new Cast_Vote();
            cv.Show();
            this.Hide();
        }
    }
    }


