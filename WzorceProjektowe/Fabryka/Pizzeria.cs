using WzorceProjektowe.Fabryka.Fabryki;
using WzorceProjektowe.Fabryka.Pizze;

namespace WzorceProjektowe.Fabryka
{
    public abstract class Pizzeria
    {
        protected abstract IFabrykaSkladnikow FabrykaSkladnikow { get; }

        public Pizza Zamow(RodzajPizzy rodzajPizzy)
        {
            Pizza pizza = WybierzSkladniki(rodzajPizzy);

            pizza.Przygotowywanie();
            pizza.Pieczenie();
            pizza.Krojenie();
            pizza.Pakowanie();

            return pizza;
        }

        protected abstract Pizza WybierzSkladniki(RodzajPizzy rodzajPizzy);
    }
}