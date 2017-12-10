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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cname = textBox1.Text;
            string address = textBox2.Text;
            string phone = textBox3.Text;
            string email = textBox4.Text;
            string discount = textBox5.Text;
            string notes = textBox6.Text;

            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();

            try
            {
                string commandString = "INSERT INTO Customers (CostumerName, Address, PhoneNumber, Email, Discount, Notes) VALUES ('" + cname + "', '" + address + "', '" + phone + "', '" + email + "','" + discount + "','"+notes+"')";
                OleDbCommand cmd = new OleDbCommand(commandString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vásárló rögzítve!");
            }
            catch
            {
                MessageBox.Show("Nem sikerült!");
            }
            conn.Close();
        }
    }
}
