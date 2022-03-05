using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public static class Temizle
    {
        public static void CheckTemizleme(FlowLayoutPanel panel)
        {
            foreach (CheckBox item in panel.Controls)
            {
                if (item.Checked)
                    item.Checked = false;
            }
        }
        public static void RadioTemizleme(FlowLayoutPanel panel)
        {
            foreach (RadioButton item in panel.Controls)
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

        public static void NumTemizle(NumericUpDown num)
        {
            if (num.Value != 1)
            {
                num.Value = 1;
            }
        }

        //public static void ControlsSil(Control a)
        //{
        //    foreach (var item in a)
        //    {
        //        if (item == ComboBox)
        //        {

        //        }
        //    }
        //}
    }
}
