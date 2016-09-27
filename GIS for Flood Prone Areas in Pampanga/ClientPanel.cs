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

namespace GIS_for_Flood_Prone_Areas_in_Pampanga
{
    public partial class ClientPanel : Form
    {
        string adminType;
        string name;
        string municipality;

        Boolean isSensorConnected = false;
        Boolean isGSMConnected = false;


        string normalWarning = "Normal Warning Message";
        string lowWarning = "Low Warning Message";
        string averageWarning = "Average Warning Message";
        string highWarning = "High Warning Message";

        string[] warningMessage; 
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

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string receivedData = serialPort1.ReadLine();
            parseReceivedData(receivedData);
        }

        private void parseReceivedData(string receivedData)
        {

            int level = -1;
            if (receivedData.Equals("normal"))
            {
                level = 0;
            }
            else if (receivedData.Equals("low"))
            {
                level = 1;
            }
            else if (receivedData.Equals("average"))
            {
                level = 2;
            }
            else if (receivedData.Equals("high"))
            {
                level = 3;
            }

            if (level > -1)
            {

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

    }
}
