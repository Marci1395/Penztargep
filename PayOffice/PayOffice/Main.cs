using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayOffice
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
        }

        private void újToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
        }

        private void újToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }

        private void újToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.Show();
        }

        private void újToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Receive r = new Receive();
            r.Show();
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale s = new Sale();
            s.Show();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersList ul = new UsersList();
            ul.Show();
        }

        private void módosításToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductsList pl = new ProductsList();
            pl.Show();
        }

        private void módosításToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SuppliersList sl = new SuppliersList();
            sl.Show();
        }

        private void mósodításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersList cl = new CustomersList();
            cl.Show();
        }
    }
}
