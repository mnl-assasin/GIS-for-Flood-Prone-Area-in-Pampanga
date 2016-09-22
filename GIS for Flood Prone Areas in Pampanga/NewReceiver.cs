using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GIS_for_Flood_Prone_Areas_in_Pampanga
{
    public partial class NewReceiver : Form
    {
        string fileName = "WarningReceiver.txt";
        string content;
        string municipality;
        public NewReceiver()
        {
            InitializeComponent();
        }
        public NewReceiver(string municipality)
        {
            InitializeComponent();
            this.municipality = municipality;
            populateBrgy(municipality);
            if (File.Exists(fileName))
            {
                content = File.ReadAllText(fileName);
            }
            else
            {
                File.WriteAllText(fileName, "");
            }
            
        }

        private void populateBrgy(string municipality)
        {
            if (municipality.Equals("Candaba"))
            {
                cboBrgy.Items.Insert(0, "Brgy San Agustin");
                cboBrgy.Items.Insert(1, "Brgy Mapaniqui");
                cboBrgy.Items.Insert(2, "Brgy Sto Rosario");
            }
            else if (municipality.Equals("Macabebe"))
            {
                cboBrgy.Items.Insert(0, "Brgy Maniago");
                cboBrgy.Items.Insert(1, "Brgy San Nicolas");
                cboBrgy.Items.Insert(2, "Brgy Bulac");
            }
            else if (municipality.Equals("Minalin"))
            {
                cboBrgy.Items.Insert(0, "Brgy Batasan");
                cboBrgy.Items.Insert(1, "Brgy Candelaria");
                cboBrgy.Items.Insert(2, "Brgy San Franciso");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string contact = txtCN.Text.Trim();
            string brgy = cboBrgy.SelectedItem.ToString();

            string newRow = municipality + ";" + name + ";" +contact + ";" + brgy + "|";
            content += newRow;
            File.WriteAllText(fileName, content);
        }
    }
}
