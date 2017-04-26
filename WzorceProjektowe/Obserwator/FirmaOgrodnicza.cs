using System;
using WzorceProjektowe.Obserwator.Kontrakty;

namespace WzorceProjektowe.Obserwator
{
    public class FirmaOgrodnicza : IObserwator
    {
        public void Aktualizuj(Pogoda pogoda)
        {
            if (pogoda.Opady == 0 && pogoda.Temperatura > 0)
            {
                Console.WriteLine("Firma Ogrodnicza: Nie ma opadow, mozemy pracowac");
            }
            else
            {
                Console.WriteLine("Firma Ogrodnicza: Nie mozemy pracowac");
            }
        }
    }
}