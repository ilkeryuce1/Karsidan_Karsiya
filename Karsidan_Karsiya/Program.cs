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
            int sayi;

            while (true)
            {
                int i = 1;
                foreach (var item in Lst.Anoktasındakiler.ToList())
                {
                    Console.WriteLine("{0} için {1} ", item.GetType().Name, i++);
                }
                string secim = Console.ReadLine();
                if (int.TryParse(secim, out sayi) && sayi <= Lst.Anoktasındakiler.Count)
                {
                    Lst.LstAdanBye(Lst.Anoktasındakiler[int.Parse(secim) - 1]);
                }

                if (sonuc & Lst.Anoktasındakiler.Count > 0)
                {
                    sonuc = Lst.Anoktasındakiler[0].Beslen(Lst.Anoktasındakiler.Last());
                }
                if (sonuc && Lst.Bnoktasındakiler.Count > 0)
                {
                    Console.WriteLine("Tekrar Karşıya gecirmek ister misiniz");
                    i = 1;
                    foreach (var item in Lst.Bnoktasındakiler.ToList())
                    {
                        Console.WriteLine("{0} için {1}", item.GetType().Name, i++);
                    }
                    Console.WriteLine("4 Hayır");
                    secim = Console.ReadLine();
                    if (int.TryParse(secim, out sayi) && sayi <= Lst.Bnoktasındakiler.Count)
                    {
                        Lst.LstBdenAya(Lst.Bnoktasındakiler[int.Parse(secim) - 1]);
                    }
                    if (Lst.Bnoktasındakiler.Count>0)
                    {
                        sonuc = Lst.Bnoktasındakiler[0].Beslen(Lst.Bnoktasındakiler.Last());
                    }
                }
                if (!sonuc)
                {
                    kontrolC.Durum(sonuc);
                    Lst.BasaDondur();
                    sonuc = true;
                }
            }
        }
    }
}
