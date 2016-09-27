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
    public partial class AdminPanel : Form
    {
        UserAccounts uAccounts;
        string[] user;
        string[] accounts;
        int ctr;
        public AdminPanel(string[] user)
        {
            InitializeComponent();
            this.user = user;
            uAccounts = new UserAccounts();
            accounts = uAccounts.getAccounts();
            loadUsers(accounts);
        }

        public void loadUsers(string[] accounts)
        {

            DataTable table = new DataTable();
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Admin Type", typeof(string)); 
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Status", typeof(string));

            string municipality = user[4];
            string[] userInfo;
            string status;
            for (ctr = 0; ctr < accounts.Length - 1; ctr++)
            {
                userInfo = uAccounts.ParseUserInfo(accounts[ctr]);
                if (userInfo[5].Equals("1"))
                {
                    status = "Active";
                }
                else
                {
                    status = "Locked";
                }
                if(municipality.Equals(userInfo[4])){
                    table.Rows.Add(userInfo[0], userInfo[2], userInfo[3], status);
                }
            }

            dataGridUsers.DataSource = table;
            dataGridUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridUsers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridUsers.Columns[0].ReadOnly = true;
            dataGridUsers.Columns[1].ReadOnly = true;
            dataGridUsers.Columns[2].ReadOnly = true;
            dataGridUsers.Columns[3].ReadOnly = true;
        }

        private void dataGridUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int colIndex = dataGridUsers.SelectedCells[0].ColumnIndex;
            int rowIndex = dataGridUsers.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridUsers.Rows[rowIndex];
            string status = row.Cells[3].Value.ToString();
            if (status.Equals("Locked"))
            {
                DialogResult result = MessageBox.Show("Do you want to unlock this user account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string username = row.Cells[0].Value.ToString();
                    unlockedAccount(username);
                }
            }
            else
            {
                MessageBox.Show("Account is Active!");
            }
        }

        private void unlockedAccount(string username)
        {
            string newAccounts = "";
            for (ctr = 0; ctr < accounts.Length - 1; ctr++)
            {
                string[] userInfo = uAccounts.ParseUserInfo(accounts[ctr]);
                if (userInfo[0].Equals(username))
                {
                    string newAccount = userInfo[0] + ";" + userInfo[1] + ";" + userInfo[2] + ";" + userInfo[3] + ";" + userInfo[4] + ";1|";
                    newAccounts += newAccount;
                }
                else
                {
                    newAccounts += accounts[ctr] + "|";
                }
            }

            uAccounts.saveAccounts(newAccounts);
            loadUsers(new UserAccounts().getAccounts());  

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridUsers.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridUsers.Rows[rowIndex];
            string username = row.Cells[0].Value.ToString();

            for (ctr = 0; ctr < accounts.Length - 1; ctr++)
            {
                 string[] userInfo = uAccounts.ParseUserInfo(accounts[ctr]);
                 if (userInfo[0].Equals(username))
                 {
                     Register register = new Register(userInfo, user);
                     register.Show();
                     Close();
                     break;
                 }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to delete this user account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                int rowIndex = dataGridUsers.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridUsers.Rows[rowIndex];
                string username = row.Cells[0].Value.ToString();
                string newAccounts = "";
                for (ctr = 0; ctr < accounts.Length - 1; ctr++)
                {
                    string[] userInfo = uAccounts.ParseUserInfo(accounts[ctr]);
                    if (!userInfo[0].Equals(username))
                    {
                        newAccounts += accounts[ctr] + "|";
                    }

                }
                uAccounts.saveAccounts(newAccounts);
                MessageBox.Show("Account deleted Successfully!");
                loadUsers(new UserAccounts().getAccounts());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientPanel cPanel = new ClientPanel(user);
            cPanel.Show();
        }


    }
}
