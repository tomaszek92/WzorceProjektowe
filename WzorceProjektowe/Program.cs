﻿using System;
using System.Threading.Tasks;
using WzorceProjektowe.Dekorator;
using WzorceProjektowe.Fabryka;
using WzorceProjektowe.Fabryka.Pizze;
using WzorceProjektowe.Obserwator;
using WzorceProjektowe.Polecenie;
using WzorceProjektowe.Polecenie.ObslugaDrzwiGarazowych;
using WzorceProjektowe.Polecenie.ObslugaSwiatla;
using WzorceProjektowe.Singleton;

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

            //Task task1 = Task.Factory.StartNew(() => SingletonOperation(5));
            //Task task2 = Task.Factory.StartNew(() => SingletonOperation(6));
            //Task task3 = Task.Factory.StartNew(() => SingletonOperation(21));
            //Task task4 = Task.Factory.StartNew(() => SingletonOperation(3));
            //Task task5 = Task.Factory.StartNew(() => SingletonOperation(8));

            #endregion

            #region Polecenie

            Pilot pilot = new Pilot();

            Swiatlo swiatlo = new Swiatlo();
            pilot.UstawPolecenie(0, new PolecenieWlaczSwiatlo(swiatlo), new PolecenieWylaczSwiatlo(swiatlo));

            DrzwiGarazowe drzwiGarazowe = new DrzwiGarazowe();
            pilot.UstawPolecenie(2, new PolecenieOtworzDrzwiGarazowe(drzwiGarazowe),
                new PolecenieZamknijDrzwiGarazowe(drzwiGarazowe));

            pilot.WcisnietoPrzyciskWlacz(0);
            pilot.WcisnietoPrzyciskWstecz();

            Console.WriteLine(pilot);

            #endregion

            Console.ReadKey();
        }

        private static void SingletonOperation(int value)
        {
            Integer singleton = Singleton<Integer>.PobierzInstancję();
            Console.WriteLine($"Value before update: {singleton.Value}");
            singleton.Value = value;
            Console.WriteLine($"Value after update: {singleton.Value}");
        }
    }
}