using System;

namespace WzorceProjektowe.Kompozyt
{
    public abstract class MenuSkladnik
    {
        public abstract void Dodaj(MenuSkladnik menuSkladnik);

        public abstract void Usun(MenuSkladnik menuSkladnik);

        public abstract MenuSkladnik PobierzPotomek(int i);

        public abstract string PobierzNazwe();

        public abstract string PobierzOpis();

        public abstract double PobierzCene();

        public abstract bool CzyJestWegetarianska();

        public abstract void Drukuj();
    }
}