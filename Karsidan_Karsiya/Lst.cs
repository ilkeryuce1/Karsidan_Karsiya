using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Karsidan_Karsiya
{
    public static class Lst
    {
        public static List<Canlı> Anoktasındakiler = new List<Canlı>();
        public static List<Canlı> Bnoktasındakiler = new List<Canlı>();
        public static void LstAdanBye(Canlı canli)
        {
            Gecis(canli);
            Bnoktasındakiler.Add(canli);
            Anoktasındakiler.Remove(canli);
        }
        public static void LstBdenAya(Canlı canli)
        {
            Gecis(canli);
            Anoktasındakiler.Add(canli);
            Bnoktasındakiler.Remove(canli);
        }
        public static void BasaDondur()
        {
            Bnoktasındakiler.Clear();
            Anoktasındakiler.Clear();
            Kuzu kuzu = new Kuzu();
            Kurt kurt = new Kurt();
            Ot ot = new Ot();
            Anoktasındakiler.Add(kuzu);
            Anoktasındakiler.Add(kurt);
            Anoktasındakiler.Add(ot);
        }
        static void Gecis(Canlı canli)
        {
            Console.WriteLine("{0} Karşıya Geçiyor", canli.GetType().Name);
            //Thread.Sleep(2000);
            Console.WriteLine("{0} Başarıyla Karşıya Geçti\n", canli.GetType().Name);
        }

        public static bool YemeyeCalis(List<Canlı> liste)
        {
            Hayvan etcil = liste.FirstOrDefault(n => n is Hayvan && ((Hayvan)n).BeslenmeTuru == BeslenmeTuruConst.BeslenmeTuru.Etcil) as Hayvan;
            Hayvan otcul = liste.FirstOrDefault(n => n is Hayvan && ((Hayvan)n).BeslenmeTuru == BeslenmeTuruConst.BeslenmeTuru.Otcul) as Hayvan;
            Bitki bitki = liste.FirstOrDefault(n => n is Bitki) as Bitki;

            return (etcil != null && otcul != null) || (otcul != null && bitki != null);
        }

    }
}
