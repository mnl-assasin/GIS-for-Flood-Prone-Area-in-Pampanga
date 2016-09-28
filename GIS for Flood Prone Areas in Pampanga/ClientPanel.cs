using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace GIS_for_Flood_Prone_Areas_in_Pampanga
{
    public partial class ClientPanel : Form
    {
        string adminType;
        string name;
        string municipality;

        Boolean isSensorConnected = false;
        Boolean isGSMConnected = false;

        int level = -1;

        static string normalWarning = "Normal Warning Message";
        static string lowWarning = "Low Warning Message";
        static string averageWarning = "Average Warning Message";
        static string highWarning = "High Warning Message";

        string[] receiver;

        Bitmap[] bmpCandabaBrgy1 = { Properties.Resources.candaba_brgy1_normal, Properties.Resources.candaba_brgy1_low, Properties.Resources.candaba_brgy1_average, Properties.Resources.candaba_brgy1_high };
        Bitmap[] bmpCandabaBrgy2 = { Properties.Resources.candaba_brgy2_normal, Properties.Resources.candaba_brgy2_low, Properties.Resources.candaba_brgy2_average, Properties.Resources.candaba_brgy2_high };
        Bitmap[] bmpCandabaBrgy3 = { Properties.Resources.candaba_brgy3_normal, Properties.Resources.candaba_brgy3_low, Properties.Resources.candaba_brgy3_average, Properties.Resources.candaba_brgy3_high };

        private string[] warningMessage = {normalWarning, lowWarning, averageWarning, highWarning}; 
        public ClientPanel()
        {
            InitializeComponent();
        }
        public ClientPanel(string[] userInfo)
        {
            InitializeComponent();

            adminType = userInfo[2];
            name = userInfo[3];
            municipality = userInfo[4];
            displayMap(municipality);

            lblAccountName.Text = name;
            lblAdminType.Text = adminType;
            //lblArea.Text = municipality;

            cboSensorPort.DataSource = SerialPort.GetPortNames();
            cboGSM.DataSource = SerialPort.GetPortNames();
            loadReceiver();
        }

        private void loadReceiver()
        {
            string fileName = "WarningReceiver.txt";
            string content;
            if (File.Exists(fileName))
            {
                content = File.ReadAllText(fileName);
                receiver = content.Split('|');
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ReceiverCMS rCMS = new ReceiverCMS(municipality);
            rCMS.Show();
        }

        private void btnSensorPort_Click(object sender, EventArgs e)
        {
            if (!isSensorConnected)
            {
                cboSensorPort.Enabled = false;
                serialPort1.PortName = cboSensorPort.SelectedItem.ToString();
                serialPort1.Open();
                btnSensorPort.Text = "Disconnect";
                isSensorConnected = true;
            }
            else
            {
                cboSensorPort.Enabled = true;
                serialPort1.Close();
                btnSensorPort.Text = "Connect";
                isSensorConnected = false;

            }
        }

        private void btnGSMPort_Click(object sender, EventArgs e)
        {
            if (!isGSMConnected)
            {
                cboGSM.Enabled = false;
                serialPort2.PortName = cboSensorPort.SelectedItem.ToString();
                serialPort2.Open();
                Thread.Sleep(3000);
                serialPort2.Write("AT+CMGF=1\r");
                btnGSMPort.Text = "Disconnect";
                isGSMConnected = true;

                sendSMS("+639350963933", "SENT FROM GSM MODULE");
            }
            else
            {
                cboGSM.Enabled = true;
                serialPort2.Close();
                btnGSMPort.Text = "Connect";
                isGSMConnected = false;

            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string receivedData = serialPort1.ReadLine();
            parseReceivedData(receivedData);
        }

        private void parseReceivedData(string receivedData)
        {
            level = -1;
            string warningLevel = "";
            if (receivedData.Equals("normal"))
            {
                level = 0;
                warningLevel = "A Normal water level state has been read by the sensor";
            }
            else if (receivedData.Equals("low"))
            {
                level = 1;
                warningLevel = "A low water level state has been read by the sensor";
            }
            else if (receivedData.Equals("average"))
            {
                level = 2;
                warningLevel = "An average water level state has been read by the sensor";
            }
            else if (receivedData.Equals("high"))
            {
                level = 3;
                warningLevel = "A high water level state has been read by the sensor";
            }

            if (level != -1)
            {
                DialogResult result = MessageBox.Show(warningLevel, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    panelCandaba.Enabled = true;
                }
            }
        }

        private void displayMap(string municipality)
        {
            if (municipality.Equals("Candaba"))
            {
                panelCandaba.Visible = true;
            }
            else if (municipality.Equals("Macabebe"))
            {

            }
            else if (municipality.Equals("Minalin"))
            {

            }
        }

        private void candabaBrgy1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brgy 1");
            candabaBrgy1.Image = bmpCandabaBrgy1[level];
            broadcastMessage("Brgy Mapaniqui");
        }

        private void candabaBrgy2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brgy 2");
            broadcastMessage("Brgy San Agustin");
        }

        private void candabaBrgy3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brgy 3");
            broadcastMessage("Brgy Sto Rosario");
        }

        private void broadcastMessage(string brgy)
        {
            // Brgy + Warning message;
            // number where to send;

            string message = brgy + " " + warningMessage[level];
            for (int ctr = 0; ctr < receiver.Length - 1; ctr++)
            {
                string[] receiverInfo = receiver[ctr].Split(';');
                if (municipality.Equals(receiverInfo[0]) && brgy.Equals(receiverInfo[3]))
                {
                    string name = receiverInfo[1];
                    string number = receiverInfo[2];
                    MessageBox.Show("MESSAGE:\n" + message + "\nReceiver name: " + name + "\nReceiver number: "+ number);
                }
            }

        }

        private void sendSMS(string number, string message)
        {
            Thread.Sleep(1000);
            serialPort2.Write("AT+CMGS=\"" + number + "\"\r\n");
            Thread.Sleep(1000);
            serialPort2.Write(message + "\x1A");
            Thread.Sleep(2000);
            MessageBox.Show("Message Sent!");
        
        }

    }
}
