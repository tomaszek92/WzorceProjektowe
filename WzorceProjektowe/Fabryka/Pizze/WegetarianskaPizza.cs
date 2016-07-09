using WzorceProjektowe.Fabryka.Fabryki;

namespace WzorceProjektowe.Fabryka.Pizze
{
    public class WegetarianskaPizza : Pizza
    {
        protected override string Nazwa => "Wegetarianska";


        public WegetarianskaPizza(IFabrykaSkladnikow fabrykaSkladnikow) : base(fabrykaSkladnikow)
        {
        }

        public override void Przygotowywanie()
        {
            Ciasto = FabrykaSkladnikow.UtworzCiasto();
            Ser = FabrykaSkladnikow.UtworzSer();
            Sos = FabrykaSkladnikow.UtworzSos();
            Warzywa = FabrykaSkladnikow.UtworzWarzywa();
            Mieso = null;
        }
    }
}