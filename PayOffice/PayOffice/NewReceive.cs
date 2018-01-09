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
    public partial class NewReceive : Form
    {
        DataTable dt;
        int max;

        public NewReceive()
        {
            InitializeComponent();
        }
        public NewReceive(DataTable d)
        {
            InitializeComponent();
            dt = d;
            dataGridView1.DataSource = dt;
            max = dt.Rows.Count;

        }

        private void NewReceive_Load(object sender, EventArgs e)
        {

        }
        string selected;
        int id = 0;
        double osszes;
        public void sum()
        {
            osszes = 0;
            for (int i = 0; i < max; i++)
            {
                double a = double.Parse(dt.Rows[i][2].ToString());
                double b = double.Parse(dt.Rows[i][3].ToString());
                double c = a * b;
                osszes = osszes + c;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // string szallito = textBox1.Text;
                string szallito = "1";
                string datum = textBox2.Text;
                string netto = osszes.ToString();
                double b = osszes * 1.27;
                string brutto = b.ToString();
                string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
                OleDbConnection conn = new OleDbConnection(connstring);
                conn.Open();
                string command = "Select MAX(ID) FROM Receives";
                OleDbCommand cmd = new OleDbCommand(command, conn);
                string res = Convert.ToString(cmd.ExecuteScalar());
                id = int.Parse(res);
                id++;
                command = "INSERT INTO Receives (ID, SupplierID, BillingDate, Net, Gross) VALUES ('" + id + "', '" + szallito + "', '" + datum + "', '" + netto + "', '" + brutto + "')";
                cmd = new OleDbCommand(command, conn);
                cmd.ExecuteNonQuery();
                for (int i = 0; i < max; i++)
                {

                    string tid = dt.Rows[i][0].ToString();
                    string db = dt.Rows[i][2].ToString();
                    string net = dt.Rows[i][3].ToString();
                    string command2 = "INSERT INTO ReceivesLineItems (ReceiveID, ProductID, Quantity, Cost) VALUES (" + id + ", " + tid + ", " + db + ", " + net + ")";
                    OleDbCommand cmd2 = new OleDbCommand(command2, conn);
                    cmd2.ExecuteNonQuery();

                }
                conn.Close();
                MessageBox.Show("Sikeres mentés!");
            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült!");
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selected = dataGridView1.CurrentCell.RowIndex.ToString();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = int.Parse(selected);
                string db = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string ar = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dt.Rows[index][2] = db;
                dt.Rows[index][3] = ar;
                sum();
                label2.Text = osszes.ToString();
            }
            catch
            { }
            
        }
    }
}
