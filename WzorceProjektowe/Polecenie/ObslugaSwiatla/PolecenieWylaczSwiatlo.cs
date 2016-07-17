namespace WzorceProjektowe.Polecenie.ObslugaSwiatla
{
    public class PolecenieWylaczSwiatlo : IPolecenie
    {
        private readonly Swiatlo _swiatlo;

        public PolecenieWylaczSwiatlo(Swiatlo swiatlo)
        {
            _swiatlo = swiatlo;
        }

        public void Wykonaj()
        {
            _swiatlo.Wylacz();
        }

        public void Cofnij()
        {
            _swiatlo.Wlacz();
        }
    }
}