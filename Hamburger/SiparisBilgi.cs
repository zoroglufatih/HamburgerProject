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
    public partial class SiparisBilgi : Form
    {
        public SiparisBilgi()
        {
            InitializeComponent();
        }

        private void SiparisBilgi_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal sosCiro = 0;
            int adet = 0;
            foreach (Siparisler item in Siparis.siparisler)
            {
                foreach (ExtraMalzemeler item2 in item.ExtraMalzemeler)
                {
                    sosCiro += item2.ExtraMalzemeFiyati * item.Adet;
                }
            }

            foreach (var item in Siparis.siparisler)
            {
                ciro += item.ToplamFiyat;
                adet += item.Adet;
                lbMevcut.Items.Add(item.ToString());
                //sosCiro = item.ExtraMalzemeler.Count;
            }

            lblCiro.Text = ciro.ToString();
            lblSipSayisi.Text = Siparis.siparisler.Count.ToString();
            lblUrunAdet.Text = adet.ToString();
            lblExCiro.Text = sosCiro.ToString();
        }
    }
}
