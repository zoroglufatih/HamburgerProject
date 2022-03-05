using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class HamburgerEkle : Form
    {
        public HamburgerEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siparis.menuler.Add(new Menuler()
            {
                MenuAdi = textBox1.Text,
                MenuFiyati = Convert.ToDecimal(textBox2.Text)
            });
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
