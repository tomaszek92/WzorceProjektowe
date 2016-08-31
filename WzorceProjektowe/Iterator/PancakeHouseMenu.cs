using System.Collections;
using System.Collections.Generic;

namespace WzorceProjektowe.Iterator
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly List<PozycjaMenu> _pozycjeMenu;

        public PancakeHouseMenu()
        {
            _pozycjeMenu = new List<PozycjaMenu>
            {
                new PozycjaMenu("Nalesniki z jagodami", true, 19.99m),
                new PozycjaMenu("Nalesniki z mięsem", false, 14.99m)
            };
        }

        public IMenuIterator UtworzMenuIterator()
        {
            return new PancakeHouseMenuIterator(_pozycjeMenu);
        }

        public IEnumerator GetEnumerator()
        {
            return _pozycjeMenu.GetEnumerator();
        }
    }
}