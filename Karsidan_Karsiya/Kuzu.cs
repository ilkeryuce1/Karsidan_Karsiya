using System.Diagnostics.SymbolStore;

namespace Karsidan_Karsiya
{
    public class Kuzu : Hayvan
    {
        public Kuzu()
        {
            BeslenmeTuru = BeslenmeTuruConst.BeslenmeTuru.Otcul;
        }
        public override bool YemeyiDene(Canlı c, out string sonuc)
        {
            bool yedi = c is Bitki;
            sonuc = yedi ? $"Kuzu {c.GetType().Name} objesini 7" : string.Empty;
            return yedi;
        }
    }
}
