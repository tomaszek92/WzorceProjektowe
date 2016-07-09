using System;
using WzorceProjektowe.Fabryka.Fabryki;
using WzorceProjektowe.Fabryka.Pizze;

namespace WzorceProjektowe.Fabryka
{
    public class WloskaPizzeria : Pizzeria
    {
        protected override IFabrykaSkladnikow FabrykaSkladnikow { get; } = new WloskaFabrykaSkladnikow();

        protected override Pizza WybierzSkladniki(RodzajPizzy rodzajPizzy)
        {
            switch (rodzajPizzy)
            {
                case RodzajPizzy.Wegetarianska:
                    return new WegetarianskaPizza(FabrykaSkladnikow);
                case RodzajPizzy.Miesna:
                    return new MiesnaPizza(FabrykaSkladnikow);
                default:
                    throw new ArgumentOutOfRangeException(nameof(rodzajPizzy), rodzajPizzy, null);
            }
        }
    }
}