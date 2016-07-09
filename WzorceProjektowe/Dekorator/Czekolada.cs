using System;

namespace WzorceProjektowe.Dekorator
{
    public class Czekolada : SkladnikDekorator
    {
        private readonly Napoj _napoj;

        public Czekolada(Napoj napoj)
        {
            _napoj = napoj;
        }

        public override string Opis => $"{_napoj.Opis}, Czelolada";
        public override double Cena => _napoj.Cena + 0.2;
    }
}