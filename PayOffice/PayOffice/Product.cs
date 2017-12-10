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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pname = textBox1.Text;
            string saleprice = textBox2.Text;
            string minq = textBox3.Text;
            string IN = textBox4.Text;
            string CTN = textBox5.Text;
            string notes = textBox6.Text;

            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();

            try
            {
                string commandString = "INSERT INTO Products (ProductName, SalePrice, MinQuantity, ItemNumber, CTN, Notes) VALUES ('" + pname + "', '" + saleprice + "', '" + minq + "', '" + IN + "','" + CTN + "','"+notes+"')";
                OleDbCommand cmd = new OleDbCommand(commandString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Új termék rögzítve!");
            }
            catch
            {
                MessageBox.Show("Nem sikerült!");
            }
            conn.Close();
        }
    }
}
