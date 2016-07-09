using System;
using System.Linq;
using WzorceProjektowe.Fabryka.Fabryki;
using WzorceProjektowe.Fabryka.Skladniki.Ciasta;
using WzorceProjektowe.Fabryka.Skladniki.Miesa;
using WzorceProjektowe.Fabryka.Skladniki.Sery;
using WzorceProjektowe.Fabryka.Skladniki.Sosy;
using WzorceProjektowe.Fabryka.Skladniki.Warzywa;

namespace WzorceProjektowe.Fabryka.Pizze
{
    public abstract class Pizza
    {
        protected readonly IFabrykaSkladnikow FabrykaSkladnikow;
        protected abstract string Nazwa { get; }

        protected Ciasto Ciasto;
        protected Ser Ser;
        protected Sos Sos;
        protected Warzywo[] Warzywa;
        protected Mieso Mieso;

        protected Pizza(IFabrykaSkladnikow fabrykaSkladnikow)
        {
            FabrykaSkladnikow = fabrykaSkladnikow;
        }

        public abstract void Przygotowywanie();

        public void Pieczenie()
        {
            Console.WriteLine("pieczenie...");
        }

        public void Krojenie()
        {
            Console.WriteLine("krojenie...");
        }

        public void Pakowanie()
        {
            Console.WriteLine("pakowanie...");
        }

        public override string ToString()
        {
            return
                $"Nazwa: {Nazwa}, Ciasto: {Ciasto}, Ser: {Ser}, Sos: {Sos}, Warzywa: ({String.Join(", ", Warzywa.Select(x => x.ToString()))}), Mieso: {Mieso}";
        }
    }
}