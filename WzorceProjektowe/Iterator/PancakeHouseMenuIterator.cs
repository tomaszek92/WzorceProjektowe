using System.Collections.Generic;

namespace WzorceProjektowe.Iterator
{
    public class PancakeHouseMenuIterator : IMenuIterator
    {
        private readonly List<PozycjaMenu> _pozycjeMenu;
        private int _pozycja;

        public PancakeHouseMenuIterator(List<PozycjaMenu> pozycjeMenu)
        {
            _pozycjeMenu = pozycjeMenu;
            _pozycja = 0;
        }

        public bool HasNext()
        {
            return _pozycja < _pozycjeMenu.Count;
        }

        public object Next => _pozycjeMenu[_pozycja++];
    }
}