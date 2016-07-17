using System;
using System.Text;

namespace WzorceProjektowe.Polecenie
{
    public class Pilot
    {
        private const int LiczbaSlotow = 7;
        private readonly IPolecenie[] _poleceniaWlacz;
        private readonly IPolecenie[] _poleceniaWylacz;
        private IPolecenie _polecenieWstecz;

        public Pilot()
        {
            _poleceniaWlacz = new IPolecenie[LiczbaSlotow];
            _poleceniaWylacz = new IPolecenie[LiczbaSlotow];

            IPolecenie pustePolecenie = new PoleceniePuste();
            for (int i = 0; i < LiczbaSlotow; i++)
            {
                _poleceniaWlacz[i] = pustePolecenie;
                _poleceniaWylacz[i] = pustePolecenie;
            }

            _polecenieWstecz = pustePolecenie;
        }


        public void UstawPolecenie(int numerSlotu, IPolecenie polecenieWlacz, IPolecenie polecenieWylacz)
        {
            _poleceniaWlacz[numerSlotu] = polecenieWlacz;
            _poleceniaWylacz[numerSlotu] = polecenieWylacz;
        }

        public void WcisnietoPrzyciskWlacz(int numerSlotu)
        {
            _poleceniaWlacz[numerSlotu].Wykonaj();
            _polecenieWstecz = _poleceniaWlacz[numerSlotu];
        }

        public void WcisnietoPrzyciskWylacz(int numerSlotu)
        {
            _poleceniaWylacz[numerSlotu].Wykonaj();
            _polecenieWstecz = _poleceniaWlacz[numerSlotu];
        }

        public void WcisnietoPrzyciskWstecz()
        {
            _polecenieWstecz.Cofnij();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < LiczbaSlotow; i++)
            {
                stringBuilder.AppendLine(
                    $"SLOT nr {i}, polecenie wlacz: {_poleceniaWlacz[i].GetType().Name}, polecenie wylacz: {_poleceniaWylacz[i].GetType().Name}");
            }
            return stringBuilder.ToString();
        }
    }
}