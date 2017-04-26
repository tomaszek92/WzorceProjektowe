using WzorceProjektowe.Dekorator.Napoje;

namespace WzorceProjektowe.Dekorator.Dodatki
{
    public class BitaSmietana : NapojDekorator
    {
        public BitaSmietana(Napoj napoj) : base(napoj)
        {
        }

        public override string Opis => $"{Napoj.Opis}, Bita Smietana";
        public override decimal Cena => Napoj.Cena + 0.99m;
    }
}