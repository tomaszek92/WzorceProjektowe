namespace WzorceProjektowe.Polecenie.ObslugaDrzwiGarazowych
{
    public class PolecenieZamknijDrzwiGarazowe : IPolecenie
    {
        private readonly DrzwiGarazowe _drzwiGarazowe;

        public PolecenieZamknijDrzwiGarazowe(DrzwiGarazowe drzwiGarazowe)
        {
            _drzwiGarazowe = drzwiGarazowe;
        }

        public void Wykonaj()
        {
            _drzwiGarazowe.DoDolu();
        }

        public void Cofnij()
        {
            _drzwiGarazowe.DoGory();
        }
    }
}