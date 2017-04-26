using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.DyskiTwarde;
using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.PamieciRam;
using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.Procesory;

namespace WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka
{
    public class LaptopDoGierFabryka : IFabrykaLaptopa
    {
        public DyskTwardy WybierzDyskTwardy()
        {
            return new Ssd();
        }

        public Procesor WybierzProcesor()
        {
            return new Intel();
        }

        public PamiecRam WybierzPamiecRam()
        {
            return new Ddr4();
        }
    }
}