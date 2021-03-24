using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadSrial_Port_NEW_
{
    public partial class addf : Form
    {
        public addf()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addf_Load(object sender, EventArgs e)
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
            try
            {
                if (serialPort1.IsOpen)
                {
                    //serialPort1.WriteLine(textBox_Send.Text + Environment.NewLine);
                    //serialPort1.WriteLine(textBox_Send.Text.ToString());
                    //serialPort1.WriteLine("ON");
                    serialPort1.Write(textBox_Send.Text.ToString());
                    //textBox1.AppendText("ON");
                    //serialPort1.Write("ON");

                    textBox_Send.Clear();
                    textBOX_Show_Read.Text = serialPort1.ReadExisting();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Send_Click_1(object sender, EventArgs e)
        {

        }
    }
}
