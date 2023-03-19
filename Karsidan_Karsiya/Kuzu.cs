namespace Karsidan_Karsiya
{
    public class Kuzu : Hayvan
    {
        public override bool Beslen(Canlı c)
        {
            if (c is Kuzu)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
