using WzorceProjektowe.Fabryka.Fabryki;

namespace WzorceProjektowe.Fabryka.Pizze
{
    public class MiesnaPizza : Pizza
    {
        public MiesnaPizza(IFabrykaSkladnikow fabrykaSkladnikow) : base(fabrykaSkladnikow)
        {
        }

        protected override string Nazwa => "Miesna";

        public override void Przygotowywanie()
        {
            Ciasto = FabrykaSkladnikow.UtworzCiasto();
            Ser = FabrykaSkladnikow.UtworzSer();
            Sos = FabrykaSkladnikow.UtworzSos();
            Warzywa = FabrykaSkladnikow.UtworzWarzywa();
            Mieso = FabrykaSkladnikow.UtworzMieso();
        }
    }
}