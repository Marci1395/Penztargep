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
using static WindowsFormsApplication1.Alap;

namespace WindowsFormsApplication1
{
    public partial class Regisztracio : Form
    {
        AdatbazisQledb db = new AdatbazisQledb();

        public Regisztracio()
        {
            InitializeComponent();
        }

        private void btn_vissza_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btn_felvitel_Click(object sender, EventArgs e)
        {
            db.Tagfelvétel(txt_nev.Text, Convert.ToDateTime(txt_szuletesi_ido.Text), txt_lakcim.Text, txt_felhasznalonev.Text, txt_jelszo.Text);
            
        }
    }
}
