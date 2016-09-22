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

        public ClientPanel()
        {
            InitializeComponent();
        }
        public ClientPanel(string[] userInfo)
        {
            InitializeComponent();

            adminType = userInfo[2];
            name = userInfo[3] + " " + userInfo[4] + " " + userInfo[5];
            municipality = userInfo[7];

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
    }
}
