using WzorceProjektowe.Dekorator.Napoje;

namespace WzorceProjektowe.Dekorator.Dodatki
{
    public class Cukier : NapojDekorator
    {
        public Cukier(Napoj napoj) : base(napoj)
        {
        }

        public override string Opis => $"{Napoj.Opis}, Cukier";
        public override decimal Cena => Napoj.Cena + 0.09m;
    }
}