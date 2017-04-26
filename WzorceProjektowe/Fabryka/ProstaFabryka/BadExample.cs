using System;
using WzorceProjektowe.Fabryka.Laptopy;

namespace WzorceProjektowe.Fabryka.ProstaFabryka
{
    public class BadExample
    {
        public Laptop ZlozZamowienie(Producent producent)
        {
            Laptop laptop;
            switch (producent)
            {
                case Producent.Msi:
                    laptop = new MsiLaptop();
                    break;
                case Producent.Asus:
                    laptop = new AsusLaptop();
                    break;
                case Producent.Lenovo:
                    laptop = new LenovoLaptop();
                    break;
                case Producent.Apple:
                    laptop = new AppleLaptop();
                    break;
                case Producent.Dell:
                    laptop = new DellLaptop();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(producent), producent, null);
            }
            laptop.WyswietlDane();
            return laptop;
        }
    }
}