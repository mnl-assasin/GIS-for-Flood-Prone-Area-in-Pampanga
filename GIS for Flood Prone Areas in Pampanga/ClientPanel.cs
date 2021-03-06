﻿using System;
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
        static string lowWarning = " is yellow flood alert please be ready for incoming flood";
        static string averageWarning = " is orage flood alert please be ready for immediate evacuation needed";
        static string highWarning = " is red flood alert, please keep calm and go to nearest high grounds and be safe.";

        string[] receiver;

        Bitmap[] bmpCandabaBrgy1 = { Properties.Resources.candaba_brgy1_normal, Properties.Resources.candaba_brgy1_low, Properties.Resources.candaba_brgy1_average, Properties.Resources.candaba_brgy1_high };
        Bitmap[] bmpCandabaBrgy2 = { Properties.Resources.candaba_brgy2_normal, Properties.Resources.candaba_brgy2_low, Properties.Resources.candaba_brgy2_average, Properties.Resources.candaba_brgy2_high };
        Bitmap[] bmpCandabaBrgy3 = { Properties.Resources.candaba_brgy3_normal, Properties.Resources.candaba_brgy3_low, Properties.Resources.candaba_brgy3_average, Properties.Resources.candaba_brgy3_high };

        bool isWarningDetected = false;
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
            panelCandaba.Enabled = true;
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
            string receivedData = serialPort1.ReadLine().Trim();
            MessageBox.Show(receivedData);
            parseReceivedData(receivedData);
        }

        private void parseReceivedData(string receivedData)
        {
            level = -1;
            string warningLevel = "";
            if (receivedData.Equals("0"))
            {
                level = 0;
                warningLevel = "A Normal water level state has been read by the sensor";
            }
            else if (receivedData.Equals("1"))
            {
                level = 1;
                warningLevel = "A yellow flood warning has been detected";
                
            }
            else if (receivedData.Equals("2"))
            {
                level = 2;
                warningLevel = "An orange flood warning has been detected";
            }
            else if (receivedData.Equals("3"))
            {
                level = 3;
                warningLevel = "A red flood warning has been detected";
            }

            if (level != -1)
            {
                DialogResult result = MessageBox.Show(warningLevel, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    isWarningDetected = true;
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
            if (isWarningDetected)
            {
                candabaBrgy1.Image = bmpCandabaBrgy1[level];
                broadcastMessage("Brgy Sto Rosario");
            }
        }

        private void candabaBrgy2_Click(object sender, EventArgs e)
        {
            if (isWarningDetected)
            {
                candabaBrgy2.Image = bmpCandabaBrgy2[level];
                broadcastMessage("Brgy San Agustin");
            }
        }

        private void candabaBrgy3_Click(object sender, EventArgs e)
        {
            if (isWarningDetected)
            {
                candabaBrgy3.Image = bmpCandabaBrgy3[level];
                broadcastMessage("Brgy Salapunga");
            }
        }

        private void broadcastMessage(string brgy)
        {
            // Brgy + Warning message;
            // number where to send;

            //string message = brgy + " " + warningMessage[level];
            loadReceiver();
            string message = "Please be alert the " + brgy + warningMessage[level];
            for (int ctr = 0; ctr < receiver.Length - 1; ctr++)
            {
                string[] receiverInfo = receiver[ctr].Split(';');
                if (municipality.Equals(receiverInfo[0]) && brgy.Equals(receiverInfo[3]))
                {
                    string name = receiverInfo[1];
                    string number = receiverInfo[2];
                    MessageBox.Show( message + "\nReceiver name: " + name + "\nReceiver number: "+ number);
                }
            }
            isWarningDetected = false;

        }

        private void sendSMS(string number, string message)
        {
            if (serialPort2.IsOpen)
            {
                Thread.Sleep(1000);
                serialPort2.Write("AT+CMGS=\"" + number + "\"\r\n");
                Thread.Sleep(1000);
                serialPort2.Write(message + "\x1A");
                Thread.Sleep(2000);
                MessageBox.Show("Message Sent!");
            }
        
        }

        private void btnSendWarning_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
