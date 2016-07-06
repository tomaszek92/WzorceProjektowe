namespace WzorceProjektowe.Obserwator.Kontrakty
{
    public interface IObserwator
    {
        void Aktualizuj(float temperatura, float wilgotnosc, float cisnienie);
    }
}