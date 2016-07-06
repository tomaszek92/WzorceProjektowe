using System.Collections.Generic;
using System.Runtime.InteropServices;
using WzorceProjektowe.Obserwator.Kontrakty;

namespace WzorceProjektowe.Obserwator
{
    public class DanePogodowe : IPodmiot
    {
        private readonly List<IObserwator> _obserwatorzy;
        private float _temperatura;
        private float _wilgotnosc;
        private float _cisnienie;

        public DanePogodowe()
        {
            _obserwatorzy = new List<IObserwator>();
        }

        public void DodajObserwatora(IObserwator obserwator)
        {
            _obserwatorzy.Add(obserwator);
        }

        public void UsunObserwatora(IObserwator obserwator)
        {
            _obserwatorzy.Remove(obserwator);
        }

        public void PowiadomObserwatorow()
        {
            foreach (IObserwator obserwator in _obserwatorzy)
            {
                obserwator.Aktualizuj(_temperatura, _wilgotnosc, _cisnienie);
            }
        }

        public void Ustaw(float temperatura, float wilgotnosc, float cisnienie)
        {
            _temperatura = temperatura;
            _wilgotnosc = wilgotnosc;
            _cisnienie = cisnienie;

            PowiadomObserwatorow();
        }
    }
}