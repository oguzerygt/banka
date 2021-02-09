using System;
using System.Collections.Generic;
using System.Text;

namespace banka
{
    class Musteri
    {
        public Musteri(string isim, string soyIsim)
        {
            this.isim = isim;
            this.soyIsim = soyIsim;
            this.bakiye=0;
        }

        public string isim{ get; set; }
        public string soyIsim { get; set; }
        public double bakiye { get; set; }
    }
}
