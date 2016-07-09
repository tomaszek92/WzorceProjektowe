namespace WzorceProjektowe.Dekorator
{
    public class BitaSmietana : SkladnikDekorator
    {
        private readonly Napoj _napoj;

        public BitaSmietana(Napoj napoj)
        {
            _napoj = napoj;
        }

        public override string Opis => $"{_napoj.Opis}, Bita Smietana";
        public override double Cena => _napoj.Cena + 0.3;
    }
}