namespace Karsidan_Karsiya
{
    internal class Ot : Bitki
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
