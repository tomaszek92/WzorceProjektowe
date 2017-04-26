using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka;
using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.DyskiTwarde;
using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.PamieciRam;
using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.Procesory;

namespace WzorceProjektowe.Fabryka.Laptopy
{
    public abstract class Laptop
    {
        protected DyskTwardy DyskTwardy;
        protected Procesor Procesor;
        protected PamiecRam PamiecRam;

        public void Stworz(IFabrykaLaptopa fabrykaLaptopa)
        {
            DyskTwardy = fabrykaLaptopa.WybierzDyskTwardy();
            Procesor = fabrykaLaptopa.WybierzProcesor();
            PamiecRam = fabrykaLaptopa.WybierzPamiecRam();
        }

        public virtual string WyswietlDane()
        {
            return $"Procesor: {Procesor}, Pamiec RAM: {PamiecRam}, Dysk twartd: {DyskTwardy}";
        }
    }
}