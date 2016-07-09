using WzorceProjektowe.Fabryka.Skladniki.Ciasta;
using WzorceProjektowe.Fabryka.Skladniki.Miesa;
using WzorceProjektowe.Fabryka.Skladniki.Sery;
using WzorceProjektowe.Fabryka.Skladniki.Sosy;
using WzorceProjektowe.Fabryka.Skladniki.Warzywa;

namespace WzorceProjektowe.Fabryka.Fabryki
{
    public class WloskaFabrykaSkladnikow : IFabrykaSkladnikow
    {
        public Ciasto UtworzCiasto()
        {
            return new CienkieChrupiaceCiasto();
        }

        public Sos UtworzSos()
        {
            return new SosCzosnkowy();
        }

        public Ser UtworzSer()
        {
            return new SerReggiano();
        }

        public Warzywo[] UtworzWarzywa()
        {
            return new Warzywo[] {new Cebula(), new CzerwonaPapryka()};
        }

        public Mieso UtworzMieso()
        {
            return new Peperoni();
        }
    }
}