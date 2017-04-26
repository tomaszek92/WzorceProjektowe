using System;

namespace WzorceProjektowe.Fabryka.MetodaWytwórcza
{
    public interface IDostawcaLaptopow
    {
        Magazyn WybierzMagazyn(Producent producent);
    }

    public class Dostawca1Laptopow : IDostawcaLaptopow
    {
        public Magazyn WybierzMagazyn(Producent producent)
        {
            switch (producent)
            {
                case Producent.Msi:
                    return new EuropejskiMagazyn();
                case Producent.Asus:
                    return new AzjatyckiMagazyn();
                case Producent.Lenovo:
                    return new EuropejskiMagazyn();
                case Producent.Apple:
                    return new EuropejskiMagazyn();
                case Producent.Dell:
                    return new AmerykanskiMagazyn();
                default:
                    throw new ArgumentOutOfRangeException(nameof(producent), producent, null);
            }
        }
    }

    public class Dostawca2Laptopow : IDostawcaLaptopow
    {
        public Magazyn WybierzMagazyn(Producent producent)
        {
            switch (producent)
            {
                case Producent.Msi:
                    return new AzjatyckiMagazyn();
                case Producent.Asus:
                    return new AzjatyckiMagazyn();
                case Producent.Lenovo:
                    return new AmerykanskiMagazyn();
                case Producent.Apple:
                    return new AmerykanskiMagazyn();
                case Producent.Dell:
                    return new AmerykanskiMagazyn();
                default:
                    throw new ArgumentOutOfRangeException(nameof(producent), producent, null);
            }
        }
    }
}