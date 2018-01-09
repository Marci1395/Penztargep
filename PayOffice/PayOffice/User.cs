using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayOffice
{
    public partial class User : Form
    {
        string id = "";
        bool mod = false;
        public User()
        {
            InitializeComponent();
        }
        public User(string id)
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
            string command = " Select * FROM Users Where ID = " + id + "";
            dataadapter.SelectCommand = new OleDbCommand(" Select * FROM Users Where ID = " + id + "", conn);
            dataadapter.Fill(ds);
            dataadapter.Dispose();
            conn.Close();

            textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox2.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox6.Text = ds.Tables[0].Rows[0][5].ToString();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string MD5Hash(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] pw = md5.Hash;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < pw.Length; i++)
            {
                sb.Append(pw[i].ToString("x2"));
            }
            return sb.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pw1 = textBox2.Text;
            string pw2 = textBox3.Text;
            string lname = textBox4.Text;
            string fname = textBox5.Text;
            string email = textBox6.Text;
            string pw = MD5Hash(pw1);

            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();

            if(mod)
            {
                try
                {
                    string commandString = "UPDATE Users SET Username = '" + username + "', [Password] = '"+pw+"', LastName = '"+lname+"', FirstName = '"+fname+"', Email = '"+email+"' Where ID = " + id + "";
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
                    string commandString = "INSERT INTO Users (Username, [Password], LastName, FirstName, Email) VALUES ('" + username + "', '" + pw + "', '" + lname + "', '" + fname + "','" + email + "')";
                    OleDbCommand cmd = new OleDbCommand(commandString, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sikeres mentés!");
                }
                catch
                {
                    MessageBox.Show("Nem sikerült!");
                }
            }
            
            conn.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
