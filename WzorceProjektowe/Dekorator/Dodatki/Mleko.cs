using WzorceProjektowe.Dekorator.Napoje;

namespace WzorceProjektowe.Dekorator.Dodatki
{
    public class Mleko : NapojDekorator
    {
        public Mleko(Napoj napoj) : base(napoj)
        {
        }

        public override string Opis => $"{Napoj.Opis}, Mleko";
        public override decimal Cena => Napoj.Cena + 0.49m;
    }
}