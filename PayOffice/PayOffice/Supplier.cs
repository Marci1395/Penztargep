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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string company = textBox1.Text;
            string Address = textBox2.Text;
            string CName = textBox3.Text;
            string Phone = textBox4.Text;
            string Email = textBox5.Text;
            string Notes = textBox6.Text;

            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();

            try
            {
                string commandString = "INSERT INTO Suppliers (Company, Address, ContactName, PhoneNumber, Email, Notes) VALUES ('" + company + "', '" + Address + "', '" + CName + "', '" + Phone + "','" + Email + "','"+Notes+"')";
                OleDbCommand cmd = new OleDbCommand(commandString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Szállító rögzítve!");
            }
            catch
            {
                MessageBox.Show("Nem sikerült!");
            }
            conn.Close();
        }
    }
}
