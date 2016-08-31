using System;

namespace WzorceProjektowe.MetodaSzablonowa
{
    public abstract class Napoj
    {
        public void Przygotuj()
        {
            GotowanieWody();
            Zaparzenie();
            Nalanie();
        }

        private void GotowanieWody()
        {
            Console.WriteLine("Gotowanie...");
        }

        private void Nalanie()
        {
            Console.WriteLine("Nalewanie...");
        }

        protected abstract void Zaparzenie();
    }
}