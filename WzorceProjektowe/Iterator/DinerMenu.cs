using System.Collections;

namespace WzorceProjektowe.Iterator
{
    public class DinerMenu : IMenu
    {
        private readonly PozycjaMenu[] _pozycjeMenu;

        public DinerMenu()
        {
            _pozycjeMenu = new PozycjaMenu[]
            {
                new PozycjaMenu("Salatka krabowa", true, 44m),
                new PozycjaMenu("Stek", false, 50m)
            };
        }

        public IMenuIterator UtworzMenuIterator()
        {
            return new DinerMenuIterator(_pozycjeMenu);
        }

        public IEnumerator GetEnumerator()
        {
            return _pozycjeMenu.GetEnumerator();
        }
    }
}