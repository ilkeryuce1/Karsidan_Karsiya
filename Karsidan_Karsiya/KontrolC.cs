using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karsidan_Karsiya
{
    public class KontrolC : IKontrol
    {
        public void Durum(bool sonuc)
        {
            switch (sonuc)
            {
                case true: Console.WriteLine("Tebrikler Kazandınız\n"); break;
                case false: Console.WriteLine("Kaybettiniz Tekrar Deneyiniz\n"); break;
            }

        }
    }
}
