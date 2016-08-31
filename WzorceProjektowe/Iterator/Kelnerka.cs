using System;
using System.Collections;

namespace WzorceProjektowe.Iterator
{
    public class Kelnerka
    {
        private readonly IMenu _pancakeHouseMenu;
        private readonly IMenu _dinerMenu;

        public Kelnerka()
        {
            _pancakeHouseMenu = new PancakeHouseMenu();
            _dinerMenu = new DinerMenu();
        }

        public void DrukujMenuPrzyPomocyIteratorow()
        {
            IMenuIterator[] iterators = {_pancakeHouseMenu.UtworzMenuIterator(), _dinerMenu.UtworzMenuIterator()};
            foreach (IMenuIterator iterator in iterators)
            {
                while (iterator.HasNext())
                {
                    Console.WriteLine(iterator.Next);
                }
            }
        }

        public void DrukujMenuPrzyPomocyIEnumerable()
        {
            foreach (var pozycjaMenu in _pancakeHouseMenu)
            {
                Console.WriteLine(pozycjaMenu);
            }
            foreach (var pozycjaMenu in _dinerMenu)
            {
                Console.WriteLine(pozycjaMenu);
            }
        }
    }
}