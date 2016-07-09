using WzorceProjektowe.Fabryka.Skladniki.Ciasta;
using WzorceProjektowe.Fabryka.Skladniki.Miesa;
using WzorceProjektowe.Fabryka.Skladniki.Sery;
using WzorceProjektowe.Fabryka.Skladniki.Sosy;
using WzorceProjektowe.Fabryka.Skladniki.Warzywa;

namespace WzorceProjektowe.Fabryka.Fabryki
{
    public class AmerykanskaFabryka : IFabrykaSkladnikow
    {
        public Ciasto UtworzCiasto()
        {
            return new GrubeCiasto();
        }

        public Sos UtworzSos()
        {
            return new BBQ();
        }

        public Ser UtworzSer()
        {
            return new Chedar();
        }

        public Warzywo[] UtworzWarzywa()
        {
            return new Warzywo[] {new Cebula()};
        }

        public Mieso UtworzMieso()
        {
            return new Peperoni();
        }
    }
}