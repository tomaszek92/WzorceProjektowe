using System;
using WzorceProjektowe.Fasada.Kontrakty;

namespace WzorceProjektowe.Fasada
{
    public class Oswietlenie : IOswietlenie
    {
        public void Wlacz()
        {
            Console.WriteLine("Oswietlenie: Wlacz");
        }

        public void Wylacz()
        {
            Console.WriteLine("Oswietlenie: Wlacz");
        }

        public void Sciemnij()
        {
            Console.WriteLine("Wzmaczniacz: Sciemnij");
        }

        public void Rozjasnij()
        {
            Console.WriteLine("Wzmaczniacz: Rozjasnij");
        }
    }
}