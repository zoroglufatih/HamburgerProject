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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }

        public static List<Menuler> menuler = new List<Menuler>()
        {
            new Menuler() {MenuAdi = "SteakHouse", MenuFiyati = 20.50m},
            new Menuler() {MenuAdi = "KingChicken", MenuFiyati = 15.75m},
            new Menuler() {MenuAdi = "ChickenRoyal", MenuFiyati = 17}
        };

        public static List<ExtraMalzemeler> ekstraMalzeme = new List<ExtraMalzemeler>()
        {
            new ExtraMalzemeler() {ExtraMalzemeAdi = "Hardal", ExtraMalzemeFiyati = 0.5m},
            new ExtraMalzemeler() {ExtraMalzemeAdi = "Ketçap", ExtraMalzemeFiyati = 0.4m},
            new ExtraMalzemeler() {ExtraMalzemeAdi = "Mayonez", ExtraMalzemeFiyati = 0.65m},
            new ExtraMalzemeler() {ExtraMalzemeAdi = "BBQ", ExtraMalzemeFiyati = 0.75m}
        };

        public static List<Siparisler> siparisler = new List<Siparisler>();
        public static List<Siparisler> mevcutSiparisler = new List<Siparisler>();
        
        private void Form2_Load(object sender, EventArgs e)
        {
            #region Menu Combobox
            
            foreach (Menuler item in menuler)
            {
                cmbMenu.Items.Add(item);
            }

            cmbMenu.DisplayMember = "MenuAdi";
            cmbMenu.SelectedIndex = 0;
            #endregion

            #region Boyut Radio
            foreach (var item in Enum.GetValues(typeof(Boyut)))
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = item.ToString();
                radioButton.Tag = item;
                flowLayoutPanel2.Controls.Add(radioButton);
                if (item.ToString() == "Kucuk")
                {
                    radioButton.Checked = true;
                }
            }
            #endregion

            #region Extra Malzemeler CheckBox

            foreach (var item in ekstraMalzeme)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.ExtraMalzemeAdi;
                cb.Tag = item;
                flowLayoutPanel1.Controls.Add(cb);
            }
            #endregion

            #region Siparisler List

            foreach (Siparisler item in mevcutSiparisler)
            {
                listBox1.Items.Add(item);
            }

            #endregion
        }
        

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            #region gereksiz

            //int size = (int)numericUpDown1.Value;
            //string SelectedMenuName = cmbMenu.SelectedItem.ToString();
            //List<string> addedMaterials = new List<string>();
            //decimal selectedPrice;

            //foreach (var item in menuler)
            //{
            //    if (item.MenuName == SelectedMenuName)
            //    {
            //        selectedPrice = item.MenuPrice;
            //        listBox1.Items.Add(SelectedMenuName + "x" + size + "/ " + (selectedPrice * size) + "$");
            //    }
            //}

            //foreach (var item in cbList)
            //{
            //    if (item.Checked)
            //    {
            //        addedMaterials.Add(item.Text);
            //        //MessageBox.Show(item.Text);  
            //    }
            //}

            #endregion

            Siparisler sip = new Siparisler();
            sip.Menu = ((Menuler)cmbMenu.SelectedItem);
            sip.Adet = (int)numericUpDown1.Value;

            MessageBox.Show(sip.Menu.MenuAdi+ sip.Adet.ToString());
            //mevcutSiparisler.Add(sip);

            //listBox1.Controls.Add(sip.MenuAdi + " " + sip.Adet + sip.ToplamFiyat + " ");
            foreach (RadioButton rdb in flowLayoutPanel2.Controls)
            {
                if (rdb.Checked)
                {
                    sip.Boyut = (Boyut)rdb.Tag;
                }
            }

            sip.ExtraMalzemeler = new List<ExtraMalzemeler>();
            foreach (CheckBox cb in flowLayoutPanel1.Controls)
            {
                if (cb.Checked)
                {
                    sip.ExtraMalzemeler.Add((ExtraMalzemeler)cb.Tag);
                }
            }
            
            sip.Hesapla();
            listBox1.Items.Add(sip);

            mevcutSiparisler.Add(sip);
            decimal toplamTutar = 0;
            foreach (var item in mevcutSiparisler)
            {
                toplamTutar += item.ToplamFiyat;
            }

            lblHardToplam.Text = toplamTutar.ToString();
            siparisler.Add(sip);

            //Temizle();
            Hamburger.Temizle.CheckTemizleme(flowLayoutPanel1);
            Hamburger.Temizle.RadioTemizleme(flowLayoutPanel2);
            Hamburger.Temizle.NumTemizle(numericUpDown1);
        }

        public void Temizle()
        {
            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                if (item.Checked)
                    item.Checked = false;
            }

            foreach (RadioButton item in flowLayoutPanel2.Controls)
            {
                if (item.Text == "Kucuk")
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }
            }
        }

        private void btnSipTam_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Siparişinizi onaylamak ister misiniz?", "Siparis Onay",  MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                mevcutSiparisler.Clear();
                listBox1.Items.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else

            }
            
        }
    }
}
