namespace WzorceProjektowe.Iterator
{
    public class PozycjaMenu
    {
        private string Nazwa { get; set; }
        private bool JestWegetarianska { get; set; }
        private decimal Cena { get; set; }

        public PozycjaMenu(string nazwa, bool jestWegetarianska, decimal cena)
        {
            Nazwa = nazwa;
            JestWegetarianska = jestWegetarianska;
            Cena = cena;
        }

        public override string ToString()
        {
            return $"Nazwa: {Nazwa}, JestWegetarianska: {JestWegetarianska}, Cena: {Cena}";
        }
    }
}