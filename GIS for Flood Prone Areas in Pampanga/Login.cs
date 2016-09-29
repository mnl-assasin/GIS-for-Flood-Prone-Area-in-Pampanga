using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIS_for_Flood_Prone_Areas_in_Pampanga
{
    public partial class Login : Form
    {
        UserAccounts uAccounts;
        string[] accounts;
        string[] userInfo;
        
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            uAccounts = new UserAccounts();
            accounts = uAccounts.getAccounts();
           
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean isLogin = false;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            //MessageBox.Show("\"" + username + "\" : \"" + password + "\"");
            for (int ctr = 0; ctr < accounts.Length - 1; ctr++)
            {
                userInfo = uAccounts.ParseUserInfo(accounts[ctr]);
                //MessageBox.Show("\"" + userInfo[0] + "\" : \"" + userInfo[1] +"\"");
                if (userInfo[0].Equals(username) && userInfo[1].Equals(password))
                {
                    processResult(accounts[ctr]);
                    isLogin = true;
                    break;
                }
            }
            if (!isLogin)
                MessageBox.Show("Invalid username or password!");

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Register("login").Show();
            this.Hide();
        }

        private void processResult(string result)
        {
            string[] userInfo = new UserAccounts().ParseUserInfo(result);
            if(userInfo[2].Equals("Admin")){
                AdminPanel aPanel = new AdminPanel(userInfo);
                aPanel.Show();
            }else{
            ClientPanel cPanel = new ClientPanel(userInfo);
            cPanel.Show();
            }
            this.Hide();
        }
        
    }
}
