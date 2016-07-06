using System;
using WzorceProjektowe.Obserwator.Kontrakty;

namespace WzorceProjektowe.Obserwator
{
    public class WarunkiBiezaceWyswietlacz : IObserwator
    {
        private float _temperatura;
        private float _wilgotnosc;
        private float _cisnienie;

        public WarunkiBiezaceWyswietlacz(IPodmiot podmiot)
        {
            podmiot.DodajObserwatora(this);
        }

        public void Aktualizuj(float temperatura, float wilgotnosc, float cisnienie)
        {
            _temperatura = temperatura;
            _wilgotnosc = wilgotnosc;
            _cisnienie = cisnienie;

            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Temperatura: {_temperatura}, Wilgotnosc: {_wilgotnosc}, Cisnienie: {_cisnienie}";
        }
    }
}