using System;
using System.Collections.Generic;
using WzorceProjektowe.Obserwator.Kontrakty;

namespace WzorceProjektowe.Obserwator
{
    public class SprawdzaczPogody : IObserwowany
    {
        private readonly List<IObserwator> _obserwatorzy;
        private Pogoda _pogoda;

        public SprawdzaczPogody()
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
                obserwator.Aktualizuj(_pogoda);
            }
        }

        public void Ustaw(Pogoda pogoda)
        {
            _pogoda = pogoda;
            PowiadomObserwatorow();
        }
    }
}