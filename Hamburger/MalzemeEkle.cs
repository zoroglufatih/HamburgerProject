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
    public partial class MalzemeEkle : Form
    {
        public MalzemeEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siparis.ekstraMalzeme.Add(new ExtraMalzemeler()
            {
                ExtraMalzemeAdi = textBox1.Text,
                ExtraMalzemeFiyati = Convert.ToDecimal(textBox2.Text)
            });
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
