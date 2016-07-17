namespace WzorceProjektowe.Polecenie.ObslugaDrzwiGarazowych
{
    public class PolecenieOtworzDrzwiGarazowe : IPolecenie
    {
        private readonly DrzwiGarazowe _drzwiGarazowe;

        public PolecenieOtworzDrzwiGarazowe(DrzwiGarazowe drzwiGarazowe)
        {
            _drzwiGarazowe = drzwiGarazowe;
        }

        public void Wykonaj()
        {
            _drzwiGarazowe.DoGory();
        }

        public void Cofnij()
        {
            _drzwiGarazowe.DoDolu();
        }
    }
}