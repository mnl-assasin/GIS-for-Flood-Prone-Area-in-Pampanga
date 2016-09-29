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
        

        bool isEdit = false;
        public NewReceiver()
        {
            InitializeComponent();
        }

        public NewReceiver(string origin, string[] userInfo)
        {
            // municipality
            // name
            // number
            // brgy
            InitializeComponent();
           

            municipality = userInfo[0];
            txtName.Text = userInfo[1];
            txtCN.Text = userInfo[2];
            cboBrgy.SelectedText = userInfo[3];
            populateBrgy(municipality);
            isEdit = true;
            initReceiver();
            btnAdd.Text = "Update";
        }

        public NewReceiver(string municipality)
        {
            InitializeComponent();
            this.municipality = municipality;
            populateBrgy(municipality);
            initReceiver();
            
        }

        private void initReceiver(){
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
                
                cboBrgy.Items.Insert(0, "Brgy Salapunga");
                cboBrgy.Items.Insert(1, "Brgy San Agustin");
                cboBrgy.Items.Insert(2, "Brgy Sto Rosario");
            }
            else if (municipality.Equals("Macabebe"))
            {
                cboBrgy.Items.Insert(0, "Brgy Bulac");
                cboBrgy.Items.Insert(1, "Brgy Maniago");
                cboBrgy.Items.Insert(2, "Brgy San Nicolas");
                
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

                string newRow = municipality + ";" + name + ";" + contact + ";" + brgy + "|";
                if (!isEdit)
                {
                    content += newRow;
                    File.WriteAllText(fileName, content);
                    MessageBox.Show("New warning receiver added");
                }
                else
                {
                    string[] accounts = content.Split('|');
                    string newAccounts = "";

                    for (int ctr = 0; ctr < accounts.Length - 1; ctr++)
                    {
                        string[] userInfo = accounts[ctr].Split(';');
                        //MessageBox.Show(userInfo[1] + " : " + name);
                        if (name.Equals(userInfo[1]))
                        {
                            string newAccount = municipality + ";" + name + ";" + contact + ";" + brgy + "|";
                            newAccounts += newAccount;
                        }
                        else
                        {
                            newAccounts += accounts[ctr] + "|";
                        }
                    }
                    File.WriteAllText(fileName, newAccounts);
                    MessageBox.Show("Account updated succesfully!");

                }
                Close();
                new ReceiverCMS(municipality).Show();
                
        }
    }
}
