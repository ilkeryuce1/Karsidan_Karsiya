using System;

namespace Karsidan_Karsiya
{
    public class KontrolC : IOyun
    {
        const string gameOver = "Kaybettiniz Tekrar Deneyiniz";
        const string gameWin = "Tebrikler Kazandınız";
        public void Durum(bool sonuc)
        {
            if (!sonuc)
                Console.WriteLine("{0}\n", gameOver);
            else
                Console.WriteLine("{0}\n", gameWin);
            Lst.BasaDondur();
        }
    }
}
