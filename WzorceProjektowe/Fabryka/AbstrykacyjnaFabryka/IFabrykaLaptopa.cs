using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.DyskiTwarde;
using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.PamieciRam;
using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka.Procesory;

namespace WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka
{
    public interface IFabrykaLaptopa
    {
        DyskTwardy WybierzDyskTwardy();
        Procesor WybierzProcesor();
        PamiecRam WybierzPamiecRam();
    }
}