using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Vote_System
{
    public partial class QR_Reader : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
        string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");

        public QR_Reader()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void button1_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QR_Reader_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                comboBox1.Items.Add(filterInfo.Name);
            comboBox1.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            Result results = barcodeReader.Decode((Bitmap)pictureBox1.Image);
            if (results != null)
            {
                textBox1.Text = results.ToString();
                timer1.Stop();
                if (captureDevice.IsRunning)
                    captureDevice.Stop();
            }
        }

        private void QR_Reader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning == true)
                captureDevice.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                string nic = "0";
                string Nic=textBox1.Text;
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from VoterTB  WHERE NIC=@NIC ", conn);
                cmd.Parameters.AddWithValue("@NIC", textBox1.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nic = dr["NIC"].ToString();
                   
                }

                
                if (nic == Nic)
                {
                    Cast_Vote cv = new Cast_Vote();
                    cv.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Internal error: {ex}");
            }
            finally
            {
                conn.Close(); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
