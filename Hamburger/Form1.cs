using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void FormAc(Form frm)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Siparis frm = new Siparis();
            FormAc(new Siparis());
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisBilgi frm = new SiparisBilgi();
            FormAc(frm);
        }

        private void menuBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HamburgerEkle frm = new HamburgerEkle();
            FormAc(frm);
        }

        private void extraMalzemeBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MalzemeEkle frm = new MalzemeEkle();
            FormAc(frm);
        }
    }
}
