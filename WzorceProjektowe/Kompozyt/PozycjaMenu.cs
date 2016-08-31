using System;

namespace WzorceProjektowe.Kompozyt
{
    public class PozycjaMenu : MenuSkladnik
    {
        private readonly string _nazwa;
        private readonly string _opis;
        private readonly bool _czyJestWegetarianska;
        private readonly double _cena;

        public PozycjaMenu(string nazwa, string opis, bool czyJestWegetarianska, double cena)
        {
            _nazwa = nazwa;
            _opis = opis;
            _czyJestWegetarianska = czyJestWegetarianska;
            _cena = cena;
        }

        public override void Dodaj(MenuSkladnik menuSkladnik)
        {
            throw new NotImplementedException();
        }

        public override void Usun(MenuSkladnik menuSkladnik)
        {
            throw new NotImplementedException();
        }

        public override MenuSkladnik PobierzPotomek(int i)
        {
            throw new NotImplementedException();
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
            return _cena;
        }

        public override bool CzyJestWegetarianska()
        {
            return _czyJestWegetarianska;
        }

        public override void Drukuj()
        {
            Console.WriteLine(PobierzNazwe());
            if (_czyJestWegetarianska)
            {
                Console.WriteLine("\t" + CzyJestWegetarianska());
            }
            Console.WriteLine("\t" + PobierzCene());
            Console.WriteLine("\t" + PobierzOpis());
        }
    }
}