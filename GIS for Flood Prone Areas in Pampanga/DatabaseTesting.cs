using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace GIS_for_Flood_Prone_Areas_in_Pampanga
{
    public partial class DatabaseTesting : Form
    {
        OleDbCommand command;
        OleDbConnection connection;
        public DatabaseTesting()
        {
            InitializeComponent();
        }

        private void DatabaseTesting_Load(object sender, EventArgs e)
        {
            try
            {
                string con = @"Provider=Microsoft.ACE.OLEDB.12.0;
                        Data Source=C:\Users\mleano\Documents\pampanga_gis.mdb;
                        Persist Security Info=False;";
                connection = new OleDbConnection(con);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    lblStatus.Text = "Connection Succesful!";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
