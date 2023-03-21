using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Karsidan_Karsiya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuzu Kurt ve Ot Olmak Üzere 3 Karakter vardır.\n1 Kişilik yeriniz olan bot ile tek tek karakterleri karşıya geçireceksiniz.\nKurallar\n1-Kurt ile kuzu yan yana kalmayacaktır\n2-Kuzu ile de ot baş başa kalmayacaktır\n3-Sıra ile bu karakterleri karşıya geçiriniz \n");
            KontrolC kontrolC = new KontrolC();
            Lst.BasaDondur();
            bool sonuc = true;
            int sayi = 0;

            while (true)
            {
                int i = 1;
                foreach (var item in Lst.Anoktasındakiler.ToList())
                {
                    Console.WriteLine("{0} için {1} ", item.GetType().Name, i++);
                }
                Console.WriteLine("Hiçbiri {0}", i);
                if (int.TryParse(Console.ReadLine(), out sayi) && sayi <= Lst.Anoktasındakiler.Count)
                {
                    Lst.LstAdanBye(Lst.Anoktasındakiler.ElementAt(sayi - 1));
                }
                if (Lst.Anoktasındakiler.Count >= 2)
                {
                    if (Lst.Anoktasındakiler.First().YemeyiDene(Lst.Anoktasındakiler.Last(), out string sonuc1))
                    {
                        Console.WriteLine(sonuc1); sonuc=false;
                    }
                    else if (Lst.Anoktasındakiler.Last().YemeyiDene(Lst.Anoktasındakiler.First(), out string sonuc2))
                    {
                        Console.WriteLine(sonuc2); sonuc = false;
                    }
                    else
                        sonuc = true;
                }

                if (sonuc && Lst.Bnoktasındakiler.Count < 3)
                {
                    Console.WriteLine("Tekrar Karşıya gecirmek ister misiniz");
                    i = 1;
                    foreach (var item in Lst.Bnoktasındakiler.ToList())
                    {
                        Console.WriteLine("{0} için {1}", item.GetType().Name, i++);
                    }
                    Console.WriteLine("Hiçbiri {0}", i);
                    if (int.TryParse(Console.ReadLine(), out sayi) && sayi <= Lst.Bnoktasındakiler.Count)
                    {
                        Lst.LstBdenAya(Lst.Bnoktasındakiler.ElementAt(sayi - 1));
                    }
                    if (Lst.Bnoktasındakiler.Count == 2)
                    {
                        if (Lst.Bnoktasındakiler.First().YemeyiDene(Lst.Bnoktasındakiler.Last(), out string sonuc3))
                        {
                            Console.WriteLine(sonuc3); sonuc = false;
                        }
                        else if (Lst.Bnoktasındakiler.Last().YemeyiDene(Lst.Bnoktasındakiler.First(), out string sonuc4))
                        {
                            Console.WriteLine(sonuc4); sonuc = false;
                        }
                        else
                            sonuc = true;
                    }
                    if (!sonuc)
                    {
                        kontrolC.Durum(sonuc);
                        sonuc = true;
                    }
                }
                else
                {
                    kontrolC.Durum(sonuc);
                    sonuc = true;
                }
            }
        }
    }
}