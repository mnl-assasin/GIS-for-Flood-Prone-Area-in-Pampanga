using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GIS_for_Flood_Prone_Areas_in_Pampanga
{
    class UserAccounts
    {
        string content;
        string[]accounts;
        int ctr;
        public UserAccounts()
        {
            if (File.Exists("UserAccounts.txt"))
            {

                content = File.ReadAllText("UserAccounts.txt");
                accounts = content.Split('|');
            }
        }
        public string Login(string userName, string password)
        {
            for (ctr = 0; ctr < accounts.Length - 1; ctr++)
            {
                string[] userInfo = accounts[ctr].Split(';');
                if (userName.Equals(userInfo[0]) && password.Equals(userInfo[1]))
                {
                    return accounts[ctr];
                }

            }

            return "invalid";
        }

        public string[] ParseUserInfo(string userInfo)
        {
            return userInfo.Split(';');
        }

    }
}
