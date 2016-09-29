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
    public partial class ReceiverCMS : Form
    {
        string fileName = "WarningReceiver.txt";
        string municipality;
        
        string content;
        string[] accounts;
        string[] info;

        int ctr;
        public ReceiverCMS()
        {
            InitializeComponent();
        }
        
        public ReceiverCMS(string municipality)
        {
            InitializeComponent();
            this.municipality = municipality;
            
          
            populateBrgy(municipality);
        }

        private void populateBrgy(string municipality)
        {
            
            if (municipality.Equals("Candaba"))
            {
                cboBrgy.Items.Insert(0, "All Candaba");
                cboBrgy.Items.Insert(1, "Brgy San Agustin");
                cboBrgy.Items.Insert(2, "Brgy Salapunga");
                cboBrgy.Items.Insert(3, "Brgy Sto Rosario");
            }
            else if (municipality.Equals("Macabebe"))
            {
                cboBrgy.Items.Insert(0, "All Macabebe");
                cboBrgy.Items.Insert(1, "Brgy Maniago");
                cboBrgy.Items.Insert(2, "Brgy San Nicolas");
                cboBrgy.Items.Insert(3, "Brgy Bulac");
            }
            else if (municipality.Equals("Minalin"))
            {
                cboBrgy.Items.Insert(0, "All Minalin");
                cboBrgy.Items.Insert(1, "Brgy Batasan");
                cboBrgy.Items.Insert(2, "Brgy Candelaria");
                cboBrgy.Items.Insert(3, "Brgy San Franciso");
            }
            cboBrgy.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewReceiver nReceiver = new NewReceiver(municipality);
            nReceiver.Show();
            Hide();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string username = row.Cells[0].Value.ToString();
            string brgy = row.Cells[2].Value.ToString();
           // MessageBox.Show( username + " : " + brgy);
            for (ctr = 0; ctr < accounts.Length - 1; ctr++)
            {
                string[] userInfo = accounts[ctr].Split(';');
             //   MessageBox.Show(userInfo[1] + " : " + userInfo[3]);
                if(username.Equals(userInfo[1])){
                        //if(username.Equals(userInfo[1]) && brgy.Equals(3)){
                    NewReceiver nReceiver = new NewReceiver("ReceiverCMS", userInfo);
                    nReceiver.Show();
                    Hide();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this receiver?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                string username = row.Cells[0].Value.ToString();
                string newAccounts = "";
                for (ctr = 0; ctr < accounts.Length - 1; ctr++)
                {
                    string[] userInfo = accounts[ctr].Split(';');
                    if (!userInfo[1].Equals(username))
                    {
                        newAccounts += accounts[ctr] + "|";
                    }

                }

                File.WriteAllText(fileName, newAccounts);
                loadReceiver(municipality);
            }
        }

        private void cboBrgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadReceiver(municipality);
            //int index = cboBrgy.SelectedIndex;
           
            //DataTable table = new DataTable();
            //table.Columns.Add("Name", typeof(string));
            //table.Columns.Add("Number", typeof(string));
            //table.Columns.Add("Brgy", typeof(string));

            //for (ctr = 0; ctr < accounts.Length - 1; ctr++)
            //{
            //    info = accounts[ctr].Split(';');
            //    if (municipality.Equals(info[0]))
            //    {
            //        if(index == 0 || cboBrgy.SelectedItem.ToString().Equals(info[3]))
            //        table.Rows.Add(info[1], info[2], info[3]);
            //    }
            //}
            //dataGridView1.DataSource = table;
            //dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void loadReceiver(string municipality){
            if (File.Exists(fileName))
            {
                content = File.ReadAllText(fileName);
                accounts = content.Split('|');
            }

            int index = cboBrgy.SelectedIndex;

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Number", typeof(string));
            table.Columns.Add("Brgy", typeof(string));

            for (ctr = 0; ctr < accounts.Length - 1; ctr++)
            {
                info = accounts[ctr].Split(';');
                if (municipality.Equals(info[0]))
                {
                    if (index == 0 || cboBrgy.SelectedItem.ToString().Equals(info[3]))
                        table.Rows.Add(info[1], info[2], info[3]);
                }
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
