using System;
using static Karsidan_Karsiya.BeslenmeTuruConst;

namespace Karsidan_Karsiya
{
    public class Hayvan : Canlı
    {
        public BeslenmeTuru BeslenmeTuru { get; set; }

        public override bool YemeyiDene(Canlı c, out string sonuc)
        {
            throw new NotImplementedException();
        }
    }
}
