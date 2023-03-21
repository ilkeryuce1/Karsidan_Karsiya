using System.Linq;
using System;

namespace Karsidan_Karsiya
{
    public class Kurt : Hayvan
    {
        public Kurt()
        {
            BeslenmeTuru = BeslenmeTuruConst.BeslenmeTuru.Etcil;
        }
        public override bool YemeyiDene(Canlı c, out string sonuc)
        {
            bool yedi = c is Hayvan;
            sonuc = yedi ? $"Kurt {c.GetType().Name} objesini 7" : string.Empty;
            return yedi;
        }
    }
}
