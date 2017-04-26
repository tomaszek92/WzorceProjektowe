using System;
using WzorceProjektowe.Dekorator;
using WzorceProjektowe.Dekorator.Dodatki;
using WzorceProjektowe.Dekorator.Napoje;
using WzorceProjektowe.Fabryka;
using WzorceProjektowe.Fabryka.AbstrykacyjnaFabryka;
using WzorceProjektowe.Fabryka.Laptopy;
using WzorceProjektowe.Kompozyt;
using WzorceProjektowe.Obserwator;
using WzorceProjektowe.Singleton;

namespace WzorceProjektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Obserwator

            //SprawdzaczPogody sprawdzaczPogody = new SprawdzaczPogody();
            //sprawdzaczPogody.DodajObserwatora(new FirmaOgrodnicza());
            //sprawdzaczPogody.DodajObserwatora(new Hotel());

            //sprawdzaczPogody.Ustaw(new Pogoda
            //{
            //    Zachmurzenie = Zachmurzenie.Bezchmurnie,
            //    Temperatura = 25,
            //    Opady = 0,
            //    Cisnienie = 1000,
            //    Wilgotnosc = 50
            //});

            //Console.WriteLine();

            //sprawdzaczPogody.Ustaw(new Pogoda
            //{
            //    Zachmurzenie = Zachmurzenie.CalkowiteZachmurzenie,
            //    Opady = 25,
            //    Wilgotnosc = 65,
            //    Temperatura = 10,
            //    Cisnienie = 987
            //});

            #endregion

            #region Dekorator

            //Napoj napoj1 = new Kawa();
            //napoj1 = new Mleko(new BitaSmietana(napoj1));

            //Napoj napoj2 = new Herbata();
            //napoj2 = new Mleko(new BitaSmietana(new Cukier(napoj2)));

            //Console.WriteLine($"Napoj1 : {napoj1.Opis}, cena: {napoj1.Cena}");
            //Console.WriteLine($"Napoj2 : {napoj2.Opis}, cena: {napoj2.Cena}");

            #endregion

            #region Fabryka

            Laptop msiLaptop = new MsiLaptop();
            msiLaptop.Stworz(new LaptopDoGierFabryka());
            Console.WriteLine(msiLaptop.WyswietlDane());

            Laptop dellLaptop = new DellLaptop();
            dellLaptop.Stworz(new LaptopBiznesowyFabryka());
            Console.WriteLine(dellLaptop.WyswietlDane());

            #endregion

            #region Singleton

            //Task task1 = Task.Factory.StartNew(() => SingletonOperation(5));
            //Task task2 = Task.Factory.StartNew(() => SingletonOperation(6));
            //Task task3 = Task.Factory.StartNew(() => SingletonOperation(21));
            //Task task4 = Task.Factory.StartNew(() => SingletonOperation(3));
            //Task task5 = Task.Factory.StartNew(() => SingletonOperation(8));

            #endregion

            #region Polecenie

            //Pilot pilot = new Pilot();

            //Swiatlo swiatlo = new Swiatlo();
            //pilot.UstawPolecenie(0, new PolecenieWlaczSwiatlo(swiatlo), new PolecenieWylaczSwiatlo(swiatlo));

            //DrzwiGarazowe drzwiGarazowe = new DrzwiGarazowe();
            //pilot.UstawPolecenie(2, new PolecenieOtworzDrzwiGarazowe(drzwiGarazowe),
            //    new PolecenieZamknijDrzwiGarazowe(drzwiGarazowe));

            //pilot.WcisnietoPrzyciskWlacz(0);
            //pilot.WcisnietoPrzyciskWstecz();

            //Console.WriteLine(pilot);

            #endregion

            #region Adapter

            //DzikaKaczka dzikaKaczka = new DzikaKaczka();
            //DzikiIndyk dzikiIndyk = new DzikiIndyk();
            //IndykAdapter indykAdapter = new IndykAdapter(dzikiIndyk);
            //indykAdapter.Kwacz();
            //indykAdapter.Lataj();

            #endregion

            #region Fasada

            //FasadaStudiaMuzycznego fasadaStudiaMuzycznego = new FasadaStudiaMuzycznego(new OdtwarzaczCd(),
            //    new Oswietlenie(), new Wzmaczniacz());

            //fasadaStudiaMuzycznego.OdtwarzajCd();

            #endregion

            #region Metoda Szablonowa

            //new Herbata().Przygotuj();
            //Console.WriteLine();
            //new Kawa().Przygotuj();

            #endregion

            #region Iterator

            //Kelnerka kelnerka = new Kelnerka();
            //kelnerka.DrukujMenuPrzyPomocyIEnumerable();

            #endregion

            #region Kozpozyt

            //MenuSkladnik pancakeHouseMenu = new Menu("MENU PANCAKE HOUSE", "Śniadania");
            //pancakeHouseMenu.Dodaj(new PozycjaMenu("Naleśnik", "Naleśnik z truskawkami", true, 25.0));
            //pancakeHouseMenu.Dodaj(new PozycjaMenu("Herbata", "Herbata z cytryną", true, 9.89));

            //MenuSkladnik dinerMenu = new Menu("MENU RESTAURACJA DINER", "Obiady");
            //dinerMenu.Dodaj(new PozycjaMenu("Spaghetti", "Spaghetii z mięsem", false, 29.0));
            //dinerMenu.Dodaj(new PozycjaMenu("Zupa pomidorowa", "", true, 15.0));

            //MenuSkladnik wszystkieMenu = new Menu("WSZYSTKIE MENU", "Wszystko");

            //wszystkieMenu.Dodaj(pancakeHouseMenu);
            //wszystkieMenu.Dodaj(dinerMenu);

            //wszystkieMenu.Drukuj();

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