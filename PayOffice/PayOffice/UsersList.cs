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
    public partial class UsersList : Form
    {
        public UsersList()
        {
            InitializeComponent();
            getData();
        }
        void getData()
        {
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();
            string command = " Select * FROM Users";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(command, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Users");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Users";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].Value.ToString();
            User u = new User(id);
            u.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].Value.ToString();
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();
            string commandString = "DELETE * FROM Users Where ID = " + id + "";
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
