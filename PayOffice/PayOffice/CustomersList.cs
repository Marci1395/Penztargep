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
    public partial class CustomersList : Form
    {
        public CustomersList()
        {
            InitializeComponent();
            getData();
        }
        void getData()
        {
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();
            string command = " Select * FROM Customers";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(command, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Customers");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Customers";
            conn.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].Value.ToString();
            Customer c = new Customer(id);
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].Value.ToString();
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();
            string commandString = "DELETE * FROM Customers Where ID = " + id + "";
            OleDbCommand cmd = new OleDbCommand(commandString, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeres törlés!");
            getData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
