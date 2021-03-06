﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            string password = textBox2.Text;
            string pwch = MD5Hash(password);
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();
            string commandString = " Select Password FROM Users Where Username = '" + username + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(commandString, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Users");
            try
            {
                string pw = ds.Tables[0].Rows[0][0].ToString();
                if (pwch == pw)
                {
                    Main main = new Main(username);
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Nem megfelelő felhasználónév vagy jelszó!");
                }
            }
            catch
            {
                MessageBox.Show("Nincs ilyen felhasználó");
            }
            
            conn.Close();

        }
    }
}
