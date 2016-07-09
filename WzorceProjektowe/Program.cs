using System;
using WzorceProjektowe.Dekorator;
using WzorceProjektowe.Fabryka;
using WzorceProjektowe.Fabryka.Pizze;
using WzorceProjektowe.Obserwator;

namespace WzorceProjektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Obserwator

            //DanePogodowe danePogodowe = new DanePogodowe();
            //WarunkiBiezaceWyswietlacz warunkiBiezaceWyswietlacz = new WarunkiBiezaceWyswietlacz(danePogodowe);

            //danePogodowe.Ustaw(22.2f, 34f, 1000);
            //danePogodowe.Ustaw(22.2f, 44f, 999);
            //danePogodowe.Ustaw(22.2f, 14f, 1000);

            #endregion

            #region Dekorator

            //Napoj napoj1 = new Expresso();
            //napoj1 = new Czekolada(new BitaSmietana(napoj1));

            //Napoj napoj2 = new StarCaeSpecial();
            //napoj2 = new Czekolada(napoj2);

            //Console.WriteLine($"Napoj1 : {napoj1.Opis}, cena: {napoj1.Cena}");
            //Console.WriteLine($"Napoj2 : {napoj2.Opis}, cena: {napoj2.Cena}");

            #endregion

            #region Fabryka

            //Pizzeria pizzeria = new WloskaPizzeria();

            //Pizza pizza = pizzeria.Zamow(RodzajPizzy.Miesna);

            //Console.WriteLine(pizza);

            #endregion

            #region Singleton

            #endregion

            Console.ReadKey();
        }
    }
}