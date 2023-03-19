using System;
using System.Linq;

namespace Karsidan_Karsiya
{
    internal class Program
    {
        static void Main(string[] args)
        {

            KontrolC kontrolC = new KontrolC();
            Lst.BasaDondur();
            bool sonuc = true;

            while (Lst.Bnoktasındakiler.Count <= 3)
            {
                int i = 1;
                foreach (var item in Lst.Anoktasındakiler.ToList())
                {
                    Console.WriteLine("{0} için {1} ", item.GetType().Name, i++);
                }

                string secim = Console.ReadLine();
                Lst.LstAdanBye(Lst.Anoktasındakiler[int.Parse(secim) - 1]);
                if (sonuc && Lst.Anoktasındakiler.Count > 0)
                {
                    sonuc = Lst.Anoktasındakiler[0].Beslen(Lst.Anoktasındakiler.Last());

                }
               if (sonuc && Lst.Bnoktasındakiler.Count > 0)
                {
                    Console.WriteLine("Tekrar Kariıya gecirmek ister misiniz");
                    i = 1;
                    foreach (var item in Lst.Bnoktasındakiler.ToList())
                    {
                        Console.WriteLine("{0} için {1}", item.GetType().Name, i++);
                    }
                    Console.WriteLine("4 Hayır");
                    secim = Console.ReadLine();
                    if (int.Parse(secim) < 3)
                    {
                        Lst.LstBdenAya(Lst.Bnoktasındakiler[int.Parse(secim) - 1]);
                    }
                        sonuc = Lst.Bnoktasındakiler[0].Beslen(Lst.Bnoktasındakiler.Last());
                }
                if(!sonuc)
                {
                    kontrolC.Durum(sonuc);
                    Lst.BasaDondur();
                    sonuc = true;
                }
            }
        }
    }
}
