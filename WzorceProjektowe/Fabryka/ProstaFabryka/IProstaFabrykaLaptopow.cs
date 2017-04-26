using System;
using WzorceProjektowe.Fabryka.Laptopy;

namespace WzorceProjektowe.Fabryka.ProstaFabryka
{
    public interface IProstaFabrykaLaptopow
    {
        Laptop Utworz(Producent producent);
    }

    public class ProstaFabrykaLaptopow : IProstaFabrykaLaptopow
    {
        public Laptop Utworz(Producent producent)
        {
            switch (producent)
            {
                case Producent.Msi:
                    return new MsiLaptop();
                case Producent.Asus:
                    return new AsusLaptop();
                case Producent.Lenovo:
                    return new LenovoLaptop();
                case Producent.Apple:
                    return new AppleLaptop();
                case Producent.Dell:
                    return new DellLaptop();
                default:
                    throw new ArgumentOutOfRangeException(nameof(producent), producent, null);
            }
        }
    }
}