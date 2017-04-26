namespace WzorceProjektowe.Obserwator.Kontrakty

{
    public interface IObserwowany
    {
        void DodajObserwatora(IObserwator obserwator);
        void UsunObserwatora(IObserwator obserwator);
        void PowiadomObserwatorow();
    }
}