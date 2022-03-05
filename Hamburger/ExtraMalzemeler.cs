using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger
{
    public class ExtraMalzemeler
    {
        public string ExtraMalzemeAdi { get; set; }
        public decimal ExtraMalzemeFiyati { get; set; }
        //public Orders Orders { get; set; }

        public override string ToString()
        {
            return ExtraMalzemeAdi;
        }
    }
}
