using System;
using WzorceProjektowe.Fabryka.Fabryki;
using WzorceProjektowe.Fabryka.Pizze;

namespace WzorceProjektowe.Fabryka
{
    public class AmerykanskaPizzeria : Pizzeria
    {
        protected override IFabrykaSkladnikow FabrykaSkladnikow { get; } = new AmerykanskaFabryka();

        protected override Pizza WybierzSkladniki(RodzajPizzy rodzajPizzy)
        {
            switch (rodzajPizzy)
            {
                case RodzajPizzy.Wegetarianska:
                    throw new ArgumentException("Tylko miesne", nameof(rodzajPizzy));
                case RodzajPizzy.Miesna:
                    return new MiesnaPizza(FabrykaSkladnikow);
                default:
                    throw new ArgumentOutOfRangeException(nameof(rodzajPizzy), rodzajPizzy, null);
            }
        }
    }
}