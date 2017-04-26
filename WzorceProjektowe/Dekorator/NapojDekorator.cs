using WzorceProjektowe.Dekorator.Napoje;

namespace WzorceProjektowe.Dekorator
{
    public abstract class NapojDekorator : Napoj
    {
        protected readonly Napoj Napoj;
        public abstract override string Opis { get; }

        protected NapojDekorator(Napoj napoj)
        {
            Napoj = napoj;
        }
    }
}