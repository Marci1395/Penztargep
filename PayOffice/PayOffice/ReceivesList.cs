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
    public partial class ReceivesList : Form
    {
        public ReceivesList()
        {
            InitializeComponent();
            getData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void getData()
        {
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();
            string command = " Select * FROM Receives";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(command, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Receives");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Receives";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].Value.ToString();
            Receives r = new Receives(id);
            r.Show();
        }
    }
}
