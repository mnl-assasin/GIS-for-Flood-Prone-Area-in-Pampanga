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
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            uAccounts = new UserAccounts();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string result = uAccounts.Login(username, password);
            if (!result.Equals("invalid"))
            {
                processResult(result);
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void processResult(string result)
        {
            string[] userInfo = uAccounts.ParseUserInfo(result);
            ClientPanel cPanel = new ClientPanel(userInfo);
            cPanel.Show();
            this.Hide();
        }
        
    }
}
