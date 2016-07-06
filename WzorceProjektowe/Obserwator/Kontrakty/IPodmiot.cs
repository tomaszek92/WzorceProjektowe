namespace WzorceProjektowe.Obserwator.Kontrakty

{
    public interface IPodmiot
    {
        void DodajObserwatora(IObserwator obserwator);
        void UsunObserwatora(IObserwator obserwator);
        void PowiadomObserwatorow();
    }
}