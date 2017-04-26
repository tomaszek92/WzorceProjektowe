using System;
using WzorceProjektowe.Fabryka.Laptopy;

namespace WzorceProjektowe.Fabryka.ProstaFabryka
{
    public class GoodExample
    {
        private readonly IProstaFabrykaLaptopow _fabrykaLaptopow;

        public GoodExample(IProstaFabrykaLaptopow fabrykaLaptopow)
        {
            _fabrykaLaptopow = fabrykaLaptopow;
        }

        public Laptop ZlozZamowienie(Producent producent)
        {
            Laptop laptop = _fabrykaLaptopow.Utworz(producent);
            laptop.WyswietlDane();
            return laptop;
        }
    }
}