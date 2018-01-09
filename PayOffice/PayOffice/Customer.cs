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
        string id = "";
        bool mod = false;
        public Customer()
        {
            InitializeComponent();
        }
        public Customer(string id)
        {
            InitializeComponent();
            this.id = id;
            mod = true;
            getfromID();

        }
        void getfromID()
        {
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();
            OleDbDataAdapter dataadapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            string command = " Select * FROM Customers Where ID = " + id + "";
            dataadapter.SelectCommand = new OleDbCommand(" Select * FROM Customers Where ID = " + id + "", conn);
            dataadapter.Fill(ds);
            dataadapter.Dispose();
            conn.Close();

            textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox2.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][5].ToString();
            textBox6.Text = ds.Tables[0].Rows[0][6].ToString();


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


            if (mod)
            {
                try
                {
                    string commandString = "UPDATE Customers SET CostumerName = '" + cname + "', Address = '" + address + "', PhoneNumber = '" + phone + "', Email = '" + email + "', Discount = '" + discount + "', Notes = '" + notes + "' Where ID = " + id + "";
                    OleDbCommand cmd = new OleDbCommand(commandString, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sikeres mentés!");
                }
                catch
                {
                    MessageBox.Show("Nem sikerült!");
                }
            }
            else
            {
                try
                {
                    string commandString = "INSERT INTO Customers (CostumerName, Address, PhoneNumber, Email, Discount, Notes) VALUES ('" + cname + "', '" + address + "', '" + phone + "', '" + email + "','" + discount + "','" + notes + "')";
                    OleDbCommand cmd = new OleDbCommand(commandString, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Új termék rögzítve!");
                }
                catch
                {
                    MessageBox.Show("Nem sikerült!");
                }
            }


 
            conn.Close();
        }
    }
}
