using System;
using System.Collections.Generic;

namespace WzorceProjektowe.Kompozyt
{
    public class Menu : MenuSkladnik
    {
        private readonly List<MenuSkladnik> _menuSkladniki = new List<MenuSkladnik>();
        private readonly string _nazwa;
        private readonly string _opis;

        public Menu(string nazwa, string opis)
        {
            _nazwa = nazwa;
            _opis = opis;
        }

        public override void Dodaj(MenuSkladnik menuSkladnik)
        {
            _menuSkladniki.Add(menuSkladnik);
        }

        public override void Usun(MenuSkladnik menuSkladnik)
        {
            _menuSkladniki.Remove(menuSkladnik);
        }

        public override MenuSkladnik PobierzPotomek(int i)
        {
            return _menuSkladniki[i];
        }

        public override string PobierzNazwe()
        {
            return _nazwa;
        }

        public override string PobierzOpis()
        {
            return _opis;
        }

        public override double PobierzCene()
        {
            throw new NotImplementedException();
        }

        public override bool CzyJestWegetarianska()
        {
            throw new NotImplementedException();
        }

        public override void Drukuj()
        {
            Console.WriteLine(PobierzNazwe());
            Console.WriteLine("\t" + PobierzOpis());
            foreach (MenuSkladnik menuSkladnik in _menuSkladniki)
            {
                if (menuSkladnik is Menu)
                {
                    (menuSkladnik as Menu).Drukuj();
                }
                else
                {
                    (menuSkladnik as PozycjaMenu)?.Drukuj();
                }
            }
        }
    }
}