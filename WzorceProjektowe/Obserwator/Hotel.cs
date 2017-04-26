using System;
using WzorceProjektowe.Obserwator.Kontrakty;

namespace WzorceProjektowe.Obserwator
{
    public class Hotel : IObserwator
    {
        public void Aktualizuj(Pogoda pogoda)
        {
            if (pogoda.Zachmurzenie == Zachmurzenie.Bezchmurnie ||
                pogoda.Zachmurzenie == Zachmurzenie.CzescioweZachmurzenie)
            {
                Console.WriteLine("Hotel: Wyciagamy lezaki");
            }
            else if (pogoda.Opady > 0)
            {
                Console.WriteLine("Hotel: To bedzie brzydki dzien, chowamy lezaki");
            }
        }
    }
}