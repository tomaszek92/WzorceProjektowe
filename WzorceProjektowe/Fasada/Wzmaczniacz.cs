using System;
using WzorceProjektowe.Fasada.Kontrakty;

namespace WzorceProjektowe.Fasada
{
    public class Wzmaczniacz : IWzmaczniacz
    {
        public void Wlacz()
        {
            Console.WriteLine("Wzmaczniacz: Wlacz");
        }

        public void Wylacz()
        {
            Console.WriteLine("Wzmaczniacz: Wylacz");
        }

        public void UstawCd()
        {
            Console.WriteLine("Wzmaczniacz: UstawCd");
        }

        public void UstawGlosnosc()
        {
            Console.WriteLine("Wzmaczniacz: UstawGlosnosc");
        }
    }
}