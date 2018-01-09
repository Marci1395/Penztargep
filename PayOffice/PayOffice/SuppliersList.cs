using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayOffice
{
    public partial class SuppliersList : Form
    {
        public SuppliersList()
        {
            InitializeComponent();
            getData();
        }
        void getData()
        {
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();
            string command = " Select * FROM Suppliers";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(command, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Suppliers");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Suppliers";
            conn.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
