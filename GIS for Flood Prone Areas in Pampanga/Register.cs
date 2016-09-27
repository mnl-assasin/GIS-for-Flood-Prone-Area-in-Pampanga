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
        string[] user;
        string[] accounts;
        string status;
        Boolean isEdit = false;
        public Register()
        {
            InitializeComponent();
        }

        public Register(string[] userInfo, string[] user)
        {
            InitializeComponent();
            initializedEdit(userInfo);
            this.user = user;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string adminType = cboAdminType.SelectedItem.ToString().Trim();
            string fName = txtFName.Text.Trim();
            string municipality = cboMunicipality.SelectedItem.ToString().Trim();
 

                if (userName.Equals(""))
                    MessageBox.Show("Please enter a Username!");
                else if (password.Equals(""))
                    MessageBox.Show("Please enter a Password!");
                else if (fName.Equals(""))
                    MessageBox.Show("Please enter your Name!");
                else
                {
                    if (!isEdit)
                        registerAccount(userName, password, adminType, fName, municipality);
                    else
                        updateAccount(userName, password, adminType, fName, municipality);
                }
            

        }

        private void registerAccount(String userName, String password, String adminType, String fName, String municpality)
        {
            String newAccount = userName + ";" + password + ";" + adminType + ";" + fName + ";" + municpality + ";" + "1" + "|";
            content += newAccount;
            File.WriteAllText("UserAccounts.txt", content);
            MessageBox.Show("Registered Succesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (cboAdminType.SelectedIndex == 0)
            {
                AdminPanel aPanel = new AdminPanel(newAccount.Split(';'));
                aPanel.Show();
            }
            else
            {
                ClientPanel cPanel = new ClientPanel(newAccount.Split(';'));
                cPanel.Show();
            }
            this.Close();
        }
        private void updateAccount(String username, String password, String adminType, String fName, String municpality)
        {
            UserAccounts uAccounts = new UserAccounts();
            string[] accounts = uAccounts.getAccounts();
            string newAccounts ="";
            int ctr;
            for (ctr = 0; ctr < accounts.Length - 1; ctr++)
            {
                string[] userInfo = uAccounts.ParseUserInfo(accounts[ctr]);
                if (userInfo[0].Equals(username))
                {
                    string newAccount = username + ";" + password + ";" + adminType + ";" + fName + ";" + municpality + ";" + status + "|";
                    newAccounts += newAccount;
                }
                else
                {
                    newAccounts += accounts[ctr] + "|";
                }
            }

            uAccounts.saveAccounts(newAccounts);
            MessageBox.Show("Account updated succesfully!");
            new AdminPanel(user).Show();
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
            cboMunicipality.SelectedIndex = 0;
        }

        private void initializedEdit(string[] userInfo)
        {
            MessageBox.Show(userInfo[1]);
            isEdit = true;
            txtUsername.Text = userInfo[0];
            txtUsername.Enabled = false;
            txtPassword.Text = userInfo[1];
            txtFName.Text = userInfo[3];
            status = userInfo[5];
            if (userInfo[2].Equals("Admin"))
            {
                cboAdminType.SelectedIndex = 0;
            }
            else
            {
                cboAdminType.SelectedIndex = 1;
            }
            if (userInfo[4].Equals("Candaba"))
            {
                cboMunicipality.SelectedIndex = 0;
            }
            else if (userInfo[4].Equals("Macabebe"))
            {
                cboMunicipality.SelectedIndex = 1;
            }
            else
            {
                cboMunicipality.SelectedIndex = 2;
            }

        }
    }
}
