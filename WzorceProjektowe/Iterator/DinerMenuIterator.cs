namespace WzorceProjektowe.Iterator
{
    public class DinerMenuIterator : IMenuIterator
    {
        private readonly PozycjaMenu[] _pozycjeMenu;
        private int _pozycja;

        public DinerMenuIterator(PozycjaMenu[] pozycjeMenu)
        {
            _pozycjeMenu = pozycjeMenu;
            _pozycja = 0;
        }

        public bool HasNext()
        {
            return _pozycja < _pozycjeMenu.Length;
        }

        public object Next => _pozycjeMenu[_pozycja++];
    }
}