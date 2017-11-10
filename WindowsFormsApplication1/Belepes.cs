using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Belepes : Form
    {
        public Belepes()
        {
            InitializeComponent();
        }

        private void btn_vissza_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Close()
        {
            Form1 f = new Form1();
            f.Close();
            Belepes b = new Belepes();
            b.Close();
            Regisztracio r = new Regisztracio();
            r.Close();
        }
    }
}
