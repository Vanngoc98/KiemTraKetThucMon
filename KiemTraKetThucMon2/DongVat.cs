using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kiemtraketthucmon2
{
    class Dongvat
    {
        private string Keu;

        public string tiengkeu
        {
            get { return Keu; }
            set { Keu = value; }
        }

        public Dongvat(string stKeu)
        {
            this.Keu = stKeu;
        }

        public Dongvat()
        {
        }

        public string MauLong;
        private string Maulong;
        public string longdongvat
        {
            get { return MauLong; }
            set { MauLong = value; }
        }

        public virtual void Talk()
        {
            if (tiengkeu.Equals("Gau gau"))
                MessageBox.Show("cho keu " + this.tiengkeu);
            else if (tiengkeu.Equals("Meo meo"))
                MessageBox.Show("meo keu " + this.tiengkeu);
            if (tiengkeu.Equals("Gâu gâu") && (longdongvat.Equals("Đỏ")))
                MessageBox.Show(this.tiengkeu + " Tôi là chó lông màu:" + this.longdongvat);
            else if (tiengkeu.Equals("Meo meo") && (longdongvat.Equals("Đỏ")))
                MessageBox.Show(this.tiengkeu + " Tôi là mèo lông màu:" + this.longdongvat);
        }
    }
}