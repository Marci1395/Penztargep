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
        private BindingSource bindingSource1 = new BindingSource();
        private OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

        public Sale()
        {
            InitializeComponent();
        }

        private void GetData(string selectCommand)
        {
            try
            {
                string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
                OleDbConnection conn = new OleDbConnection(connstring);
                conn.Open();

                dataAdapter = new OleDbDataAdapter(selectCommand, connstring);
                OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
                
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (OleDbException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select ProductName, SalePrice, ItemNumber from Products");

            FillCombobox();

            dataGridView2.DataSource = bindingSource1;
            GetData("");
        }

        protected void FillCombobox()
        {
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select ID,CostumerName from Customers group by ID, CostumerName", conn);
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                comboBox1.DisplayMember = "CostumerName";
                comboBox1.ValueMember = "ID";
                comboBox1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
