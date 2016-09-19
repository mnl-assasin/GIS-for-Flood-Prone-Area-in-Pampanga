using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GIS_for_Flood_Prone_Areas_in_Pampanga
{
    public partial class Form1 : Form
    {
        // comboPorts;
        // serialArduino;
        // btnConnect;
        // btnDisconnect;
        public Form1()
        {
            InitializeComponent();
            initializedSerialPorts();
        }

        private void initializedSerialPorts()
        {
            string[] serialPorts = System.IO.Ports.SerialPort.GetPortNames();
            comboPorts.DataSource = serialPorts;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            comboPorts.Enabled = false;

            connectSerialPort();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
          
            disconnectSerialPort();
        }

        private void connectSerialPort()
        {
            String portName = comboPorts.SelectedItem.ToString();
            serialArduino.PortName = portName;
            serialArduino.BaudRate = 9600;

            if (!serialArduino.IsOpen)
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                comboPorts.Enabled = true;
                serialArduino.Open();
                lblStatus.Text = "Connected";
                readArduino();
            }
        }

        private void readArduino()
        {
           DialogResult result = MessageBox.Show("Hello World", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (result == DialogResult.Yes)
           {
               textBox1.Text = "GUMANA";
           }
           else
           {

           }
        }

        private void disconnectSerialPort()
        {
            lblStatus.Text = "Disconnected";
        }

        private void serialArduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            try
            {
                SetText(serialArduino.ReadExisting());
            }
            catch (Exception ex)
            {
                SetText(ex.ToString());
            }
             
        }

        delegate void SetTextCallback(String text);
        private void SetText(string text)
        {
            if (textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.BeginInvoke(d, new Object[] { text });

            }
            else
            {
                textBox1.AppendText(text + "\n");
            }
        }
        
    }
}
