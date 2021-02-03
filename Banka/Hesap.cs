using System;
using System.Collections.Generic;
using System.Text;

namespace Banka
{
    public class Hesap
    {
        public string HesapSahibi { get; set; }

        public decimal Bakiye { get; set; }
        public Hesap (string hesapSahibi,decimal bakiye) 
        {
            HesapSahibi = hesapSahibi;
            Bakiye = bakiye;
        }

        public void ParaYatir(decimal miktar) 
        {
            Bakiye += miktar;
        }

        public void ParaCek (decimal miktar)
        {
            if (miktar > Bakiye)
            {
                throw new ArgumentOutOfRangeException("Çekilmek istenen tutar bakiyeden fazla.");
            }
            Bakiye -= miktar ;
        }
    }
}
