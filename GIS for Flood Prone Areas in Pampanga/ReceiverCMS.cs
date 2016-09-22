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
        string[] row;
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
            if (File.Exists(fileName))
            {
                content = File.ReadAllText(fileName);     
                loadData(content.Split('|'));
            }
        }

        private void populateBrgy(string municipality)
        {
            if (municipality.Equals("Candaba"))
            {
                cboBrgy.Items.Insert(0, "Brgy San Agustin");
                cboBrgy.Items.Insert(1, "Brgy Mapaniqui");
                cboBrgy.Items.Insert(2, "Brgy Sto Rosario");
            }
            else if (municipality.Equals("Macabebe"))
            {
                cboBrgy.Items.Insert(0, "Brgy Maniago");
                cboBrgy.Items.Insert(1, "Brgy San Nicolas");
                cboBrgy.Items.Insert(2, "Brgy Bulac");
            }
            else if (municipality.Equals("Minalin"))
            {
                cboBrgy.Items.Insert(0, "Brgy Batasan");
                cboBrgy.Items.Insert(1, "Brgy Candelaria");
                cboBrgy.Items.Insert(2, "Brgy San Franciso");
            }

        }

        private void loadData(string[] row)
        {
            
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Number", typeof(string));
            table.Columns.Add("Brgy", typeof(string));

            for (ctr = 0; ctr < row.Length - 1; ctr++)
            {
                info = row[ctr].Split(';');
                if (municipality.Equals(info[0]))
                {
                    table.Rows.Add(info[1], info[2], info[3]);
                }
            }
            dataGridView1.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewReceiver nReceiver = new NewReceiver(municipality);
            nReceiver.Show();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("111", typeof(string));
            table.Columns.Add("222", typeof(string));
            table.Columns.Add("333", typeof(string));
            table.Rows.Add("444", "555", "666");
            table.Rows.Add("qqq", "www", "eee");
            table.Rows.Add("aaa", "sss", "ddd");
            table.Rows.Add("zzz", "xxx", "ccc");

            //dataGridView1.Columns.Add("name", "Name");
            //dataGridView1.Columns.Add("number", "Number");
            //dataGridView1.Columns.Add("brgy", "Barangay");

            dataGridView1.DataSource = table;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                int col = dataGridView1.SelectedCells[0].ColumnIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                string a = row.Cells[col].Value.ToString();
                MessageBox.Show(a);
            }
        }
    }
}
