using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kiemtraketthucmon
{
    class Dongvat
    {
        private string Keu;

        public string tiengkeu
        {
            get { return Keu; }
            set { Keu = value; }
        }
        public Dongvat()
        {
        }
        private string Maulong;
        public string maulong
        {
            get { return Maulong; }
            set { Maulong = value; }
        }

        public virtual void Talk()
        {
            if (tiengkeu.Equals("Gâu gâu") && (maulong.Equals("Đen")))
                MessageBox.Show(this.tiengkeu + " Tôi là chó màu long:" + this.maulong);
            else if (tiengkeu.Equals("Meo meo") && (maulong.Equals("Vàng")))
                MessageBox.Show(this.tiengkeu + " Tôi là mèo màu long:" + this.maulong);
        }
    }
}