using System;
using System.Collections.Generic;
using System.Linq;

namespace Karsidan_Karsiya
{
    public static class Lst
    {
     

        public static List<Canlı> Anoktasındakiler = new List<Canlı>();
        public static List<Canlı> Bnoktasındakiler = new List<Canlı>();
     
       public static void LstAdanBye(Canlı canli)
        {
            Bnoktasındakiler.Add(canli);
            Anoktasındakiler.Remove(canli);
        
        
        }
        public static void LstBdenAya(Canlı canli)
        {
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

      
    }
}
