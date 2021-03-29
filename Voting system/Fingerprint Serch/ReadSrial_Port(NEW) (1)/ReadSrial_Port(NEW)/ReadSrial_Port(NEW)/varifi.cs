using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;
using System.Data.SqlClient;
using System.Media;

namespace ReadSrial_Port_NEW_
{
    
    public partial class varifi : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\GitHub\Voting_System-\DB\Voting_systemDb.mdf;Integrated Security=True;Connect Timeout=30");
        public varifi( )
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            nictxt.Text = QR_Reader.nic;
            //setNIC();
        }

        public void setNIC() {
            QR_Reader r = new QR_Reader();
            string nic=r.getNic();

            nictxt.Text = nic;
        }

        private void vf()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT fingerprintID FROM VoterTb WHERE NIC ='" + nictxt.Text + "' ";
                var n = nictxt.Text;
                label4.Text = n.ToString();
                var f = (string)cmd.ExecuteScalar();
                fid.Text = f.ToString();
                nictxt.Text = "";


               
            }
            catch (SqlException er)
            {
                MessageBox.Show($"Internal Error:{er}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] strPortName = SerialPort.GetPortNames();
            foreach (string n in strPortName)
            {
                comboBox_Port.Items.Add(n);
            }
            comboBox_Port.SelectedIndex = 0;
        }


        private void BTN_Start_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = 9600;
                //serialPort1.PortName = comboBox1.SelectedItem + "";
                //serialPort1.PortName = "COM9";
                serialPort1.PortName = comboBox_Port.Text;
                serialPort1.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            textBOX_Show_Read.AppendText(serialPort1.ReadLine());
            textBOX_Show_Read.AppendText("\n");
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void BTN_Send_Click(object sender, EventArgs e)
        {
           
            }

        private void button1_Click(object sender, EventArgs e)
        {
            vf();
        }

        private void nictxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QR_Reader r = new QR_Reader();
            r.Show();
        }
    }
    }

