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
        public DatabaseTesting()
        {
            InitializeComponent();
        }

        private void DatabaseTesting_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
