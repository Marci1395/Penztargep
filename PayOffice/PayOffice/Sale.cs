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
using System.Data.Common;

namespace PayOffice
{
    public partial class Sale : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter dataadapter;
        DataSet ds;
        DataTable dt;
        string selected;
        string selected_name;
        string selected_quantity;
        string selected_cost;
        public Sale()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("SaleID", typeof(string));
            dt.Columns.Add("ProductID", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("Cost", typeof(string));
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            conn = new OleDbConnection(connstring);
            conn.Open();
            filter();
        }

        void filter()
        {
            string keres = textBox1.Text;
            string command = " Select * FROM Products Where ProductName LIKE '%" + keres + "%' ORDER BY ProductName ASC";
            dataadapter = new OleDbDataAdapter(command, conn);
            ds = new DataSet();
            dataadapter.Fill(ds, "Products");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Products";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dt.Rows.Add(selected, selected_name, selected_quantity, selected_cost);
            label2.Text = dt.Rows.Count.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                selected = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                selected_name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                selected_quantity = "1";
                selected_cost = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(selected, selected_name, selected_quantity, selected_cost);
            label2.Text = dt.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales sl = new Sales(dt);
            sl.Show();
        }
    }
}
