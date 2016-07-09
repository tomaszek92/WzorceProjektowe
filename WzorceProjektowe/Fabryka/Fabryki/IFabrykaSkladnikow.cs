using WzorceProjektowe.Fabryka.Skladniki.Ciasta;
using WzorceProjektowe.Fabryka.Skladniki.Miesa;
using WzorceProjektowe.Fabryka.Skladniki.Sery;
using WzorceProjektowe.Fabryka.Skladniki.Sosy;
using WzorceProjektowe.Fabryka.Skladniki.Warzywa;

namespace WzorceProjektowe.Fabryka.Fabryki
{
    public interface IFabrykaSkladnikow
    {
        Ciasto UtworzCiasto();
        Sos UtworzSos();
        Ser UtworzSer();
        Warzywo[] UtworzWarzywa();
        Mieso UtworzMieso();
    }
}