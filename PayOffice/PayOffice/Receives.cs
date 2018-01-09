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
    public partial class Receives : Form
    {
        string id;
        public Receives()
        {
            InitializeComponent();
            
        }
        public Receives(string id)
        {
            InitializeComponent();
            this.id = id;
            getfromID();

        }
        void getfromID()
        {
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0; data source = DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();
            string command = " Select * FROM ReceivesLineItems Where ReceiveID = " + id + "";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(command, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "ReceivesLineItems");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ReceivesLineItems";
            conn.Close();
        }
    }
}
