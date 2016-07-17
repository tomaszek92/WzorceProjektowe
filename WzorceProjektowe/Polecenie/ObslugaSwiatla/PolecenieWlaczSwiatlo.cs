namespace WzorceProjektowe.Polecenie.ObslugaSwiatla
{
    public class PolecenieWlaczSwiatlo : IPolecenie
    {
        private readonly Swiatlo _swiatlo;

        public PolecenieWlaczSwiatlo(Swiatlo swiatlo)
        {
            _swiatlo = swiatlo;
        }

        public void Wykonaj()
        {
            _swiatlo.Wlacz();
        }

        public void Cofnij()
        {
            _swiatlo.Wylacz();
        }
    }
}