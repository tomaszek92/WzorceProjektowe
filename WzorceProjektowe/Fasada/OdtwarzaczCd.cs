using System;
using WzorceProjektowe.Fasada.Kontrakty;

namespace WzorceProjektowe.Fasada
{
    public class OdtwarzaczCd : IOdtwarzaczCd
    {
        public void Wlacz()
        {
            Console.WriteLine("Odtwarzacz CD: Wlacz");
        }

        public void Wylacz()
        {
            Console.WriteLine("Odtwarzacz CD: Wylacz");
        }

        public void WysunDysk()
        {
            Console.WriteLine("Odtwarzacz CD: Wysun Dysk");
        }

        public void Odtwarzaj()
        {
            Console.WriteLine("Odtwarzacz CD: Odtwarzaj");
        }

        public void Pauza()
        {
            Console.WriteLine("Odtwarzacz CD: Pauza");
        }
    }
}