namespace WzorceProjektowe.Kompozyt
{
    public class Kelnerka
    {
        private readonly MenuSkladnik _wszystkieMenu;

        public Kelnerka(MenuSkladnik wszystkieMenu)
        {
            _wszystkieMenu = wszystkieMenu;
        }

        public void Drukuj()
        {
            _wszystkieMenu.Drukuj();
        }
    }
}