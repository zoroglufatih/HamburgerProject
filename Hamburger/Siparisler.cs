using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger
{
    public class Siparisler
    {
        public Menuler Menu { get; set; }
        public List<ExtraMalzemeler> ExtraMalzemeler { get; set; }
        public int Adet { get; set; }
        public Boyut Boyut { get; set; }
        public decimal ToplamFiyat { get; set; }


        public void Hesapla()
        {
            ToplamFiyat = 0;
            ToplamFiyat += Menu.MenuFiyati;

            switch (Boyut)
            {
                case Boyut.Kucuk: ToplamFiyat += 0; break;
                case Boyut.Orta: ToplamFiyat += ToplamFiyat * 0.1m; break;
                case Boyut.Buyuk: ToplamFiyat += ToplamFiyat * 0.2m; break;
            }

            foreach (ExtraMalzemeler item in ExtraMalzemeler)
            {
                ToplamFiyat += item.ExtraMalzemeFiyati;
            }

            ToplamFiyat *= Adet;
        }

        public override string ToString()
        {
            string malzemeler = "";
            foreach (var item in ExtraMalzemeler)
            {
                malzemeler = malzemeler + " " + item.ToString();
            }


            return $"{Menu.MenuAdi}, {Adet}, {Boyut}, {malzemeler}, {ToplamFiyat}";
        }
    }
}
