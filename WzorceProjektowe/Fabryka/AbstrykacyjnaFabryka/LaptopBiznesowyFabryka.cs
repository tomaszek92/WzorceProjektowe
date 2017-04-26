using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.DyskiTwarde;
using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.PamieciRam;
using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.Procesory;

namespace WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka
{
    public class LaptopBiznesowyFabryka : IFabrykaLaptopa
    {
        public DyskTwardy WybierzDyskTwardy()
        {
            return new Hdd();
        }

        public Procesor WybierzProcesor()
        {
            return new Amd();
        }

        public PamiecRam WybierzPamiecRam()
        {
            return new Ddr3();
        }
    }
}