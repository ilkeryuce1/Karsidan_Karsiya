using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karsidan_Karsiya
{
    internal class Kurt:Hayvan
    {
        public override bool Beslen(Canlı c)
        {

            if (c is Kuzu)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
