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
    public partial class Register : Form
    {
        string content;
        string[] accounts;   
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string adminType = cboAdminType.SelectedItem.ToString().Trim();
            string fName = txtFName.Text.Trim();
            string mName = txtMName.Text.Trim();
            string lName = txtLName.Text.Trim();
            string gender = cboGender.SelectedItem.ToString().Trim();
            string municipality = cboMunicipality.SelectedItem.ToString().Trim();

            if (userName.Equals(""))
                MessageBox.Show("Please enter a Username!");
            else if (password.Equals(""))
                MessageBox.Show("Please enter a Password!");
            else if (fName.Equals(""))
                MessageBox.Show("Please enter your First Name!");
            else if (mName.Equals(""))
                MessageBox.Show("Please enter your Middle Name!");
            else if (lName.Equals(""))
                MessageBox.Show("Please enter your Last Name!");
            else
            {
                registerAccount(userName, password, adminType, fName, mName, lName, gender, municipality);
            }

        }

        private void registerAccount(String userName, String password, String adminType, String fName, String mName, String lName, String gender, String municpality)
        {
            String newAccount = userName + ";" + password + ";" + adminType + ";" + fName + ";" + mName + ";" + lName + ";" + gender + ";" + municpality + "|";
            content += newAccount;
            File.WriteAllText("UserAccounts.txt", content);
            MessageBox.Show("Registered Succesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClientPanel cPanel = new ClientPanel(newAccount.Split(';'));
            cPanel.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();

        }

        private void Register_Load(object sender, EventArgs e)
        {
            if (File.Exists("UserAccounts.txt"))
            {
              
                content = File.ReadAllText("UserAccounts.txt");
                accounts = content.Split('|');

            }
            else
            {
                File.WriteAllText("UserAccounts.txt", "");
            }
            cboAdminType.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            cboMunicipality.SelectedIndex = 0;
        }
    }
}
