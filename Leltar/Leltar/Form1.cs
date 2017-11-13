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
using System.IO;

namespace Leltar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int current_rec;
        int number_of_rec; DataTable dt;
        private void fill()
        {
            textBox1.Text = dt.Rows[current_rec]["Megnevezes"].ToString();
            textBox3.Text = dt.Rows[current_rec]["Nettoar"].ToString();
            textBox5.Text = dt.Rows[current_rec]["ID"].ToString();
        }
        void reset()
        {
            textBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            this.ActiveControl = textBox4;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = " + @"C:\VS\Arukeszlet.accdb";
                OleDbConnection conn = new OleDbConnection(connstring);
                conn.Open();
                string keres = textBox4.Text.ToString();
                string commandString = " Select ID FROM Vonalkodok Where Vonalkod = '" + keres + "'";
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(commandString, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "Vonalkodok");

                string id = ds.Tables[0].Rows[0][0].ToString();
                int i = int.Parse(id);

                commandString = " Select * FROM Arukeszlet Where ID =" + id + "";
                dataadapter = new OleDbDataAdapter(commandString, conn);
                ds = new DataSet();
                dataadapter.Fill(ds, "Arukeszlet");
                dgv2.DataSource = ds;
                dgv2.DataMember = "Arukeszlet";
                conn.Close();

                dt = ds.Tables["Arukeszlet"];
                current_rec = 0;
                number_of_rec = dt.Rows.Count;
                fill();
                textBox4.Text = "";
                textBox2.Text = "";

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox5.Text;
            string mn = textBox1.Text;
            string db = textBox2.Text;
            string na = textBox3.Text;



            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = " + @"C:\VS\Arukeszlet.accdb";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();

            try
            {
                string commandString = "INSERT INTO Leltar (ID, Megnevezes, Darabszam, Nettoar) VALUES ('" + id + "', '" + mn + "', '" + db + "', '" + na + "')";
                OleDbCommand cmd = new OleDbCommand(commandString, conn);
                cmd.ExecuteNonQuery();
                textBox6.Text += "" + mn + "   " + db + "db";
                textBox6.Text += "\r\n";
            }
            catch
            {
                connstring = " Select Darabszam FROM Leltar Where ID = " + id + "";
                OleDbDataAdapter dataadapter1 = new OleDbDataAdapter(connstring, conn);
                DataSet ds1 = new DataSet();
                dataadapter1.Fill(ds1, "Leltar");
                ds1 = new DataSet();
                dataadapter1.Fill(ds1, "Leltar");
                dataGridView2.DataSource = ds1;
                dataGridView2.DataMember = "Leltar";
                string db1 = ds1.Tables[0].Rows[0][0].ToString();

                int a = int.Parse(db1);
                int db2 = int.Parse(db);
                int sum = a + db2;
                string sum1 = sum.ToString();
                string commandString = "UPDATE Leltar SET Darabszam = " + sum1 + " Where ID = " + id + "";
                OleDbCommand cmd = new OleDbCommand(commandString, conn);
                cmd.ExecuteNonQuery();
                textBox6.Text += "" + mn + "   " + a + "+" + db2 + " -> " + sum1 + "db";
                textBox6.Text += "\r\n";

            }

            connstring = " Select * FROM Leltar";
            OleDbDataAdapter dataadapter2 = new OleDbDataAdapter(connstring, conn);
            DataSet ds2 = new DataSet();
            dataadapter2.Fill(ds2, "Leltar");
            ds2 = new DataSet();
            dataadapter2.Fill(ds2, "Leltar");
            dataGridView1.DataSource = ds2;
            dataGridView1.DataMember = "Leltar";
            conn.Close();
            reset();
        }
    }
}
